using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SOCio.Analyze_file
{
    public class HybridAnalysis
    {

        #region Constants 
        public ILog Logger { get; set; }

        string apiKey = ConfigurationManager.AppSettings["HybridAnalysis"];

        #endregion

        #region Variables

        public string virusFamily = string.Empty;
        public int score = int.MinValue;
        public string fileInfo = string.Empty;
        public List<string> tags = new List<string>();

        #endregion

        public bool processFinished = false;

        public HybridAnalysis()
        {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();
        }

        public async Task getResult(string hash)
        {
            try
            {

                string responseUnparsed = string.Empty;

                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://www.hybrid-analysis.com/api/v2/search/hash?_timestamp=1604950533721"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "application/json");
                        request.Headers.TryAddWithoutValidation("user-agent", "Falcon Sandbox");
                        request.Headers.TryAddWithoutValidation("api-key", apiKey);

                        request.Content = new StringContent("hash=" + hash);
                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                        using (var response = await httpClient.SendAsync(request))
                        {

                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                responseUnparsed = response.Content.ReadAsStringAsync().Result;
                            }
                            else {
                                Logger.Error($"Status code from Hybrid-Analisis is: " + response.StatusCode);
                                this.processFinished = true;
                                return;
                            }

                            try
                            {
                                if (!string.IsNullOrEmpty(responseUnparsed))
                                {

                                    //We first check if the file has been uploaded to Hybrid-Analysis
                                    if ("[]".Equals(responseUnparsed)) {
                                        Logger.Info("Hybrid-Analysis doesn't have results for this hash");
                                        this.processFinished = true;
                                        return;
                                    }

                                    //The best way to parse this would be using the JSON info. I have not been able to do it. We will use RegExp instead
                                    //TODO: Parse this into string operation to gain performance.
                                    this.virusFamily = Regex.Match(responseUnparsed, @"vx_family"":""" + "(.+?)\"").Groups[1].Value;
                                    this.score  = Convert.ToInt32(Regex.Match(responseUnparsed, @"threat_score"":" + "(.+?),").Groups[1].Value);
                                    this.fileInfo = Regex.Match(responseUnparsed, @"type"":""" + "(.+?)\"").Groups[1].Value;
                                    string classifitacion = Regex.Match(responseUnparsed, @"classification_tags"":\[" + @"(.+?)""\]").Groups[1].Value;
                                    this.tags = classifitacion.Replace("\"", "").Split(',').ToList();
                                    this.processFinished = true;
                                }
                                else
                                {
                                    this.score = int.MinValue;
                                    this.processFinished = true;
                                    return;
                                }

                                
                                Logger.Debug("Parsing from Hybrid-Analysis finished correctly");
                                return;
                            }
                            catch (Exception ex)
                            {
                                this.processFinished = true;
                                Logger.Error($"Error Parsing info from Hybrid-Analysis: {ex.StackTrace} - {ex.Message}");
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error parsing results from Hybrid Analysis: {ex.StackTrace} - {ex.Message}");
                this.processFinished = true;
            }
        }

    }
}
