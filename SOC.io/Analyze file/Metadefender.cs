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
    public class Metadefender
    {

        #region Constants 
        public ILog Logger { get; set; }

        string apiKey = ConfigurationManager.AppSettings["Metadefender"];

        #endregion

        #region Variables

        int totalAV;
        int detectedAV;
        string threatName = string.Empty;

        #endregion

        public bool processFinished = false;

        public Metadefender()
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
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://api.metadefender.com/v4/hash/" + "6A5C19D9FFE8804586E8F4C0DFCC66DE"))
                    {
                        request.Headers.TryAddWithoutValidation("apikey", apiKey);

                        using (var response = await httpClient.SendAsync(request))
                        {

                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                responseUnparsed = response.Content.ReadAsStringAsync().Result;
                            }
                            else
                            {
                                Logger.Error($"Status code from Metadefender is: " + response.StatusCode);
                                this.processFinished = true;
                                return;
                            }

                            try
                            {
                                if (!string.IsNullOrEmpty(responseUnparsed))
                                {

                                    //We first check if the file has been uploaded to Hybrid-Analysis
                                    if ("[]".Equals(responseUnparsed))
                                    {
                                        Logger.Info("Hybrid-Analysis doesn't have results for this hash");
                                        this.processFinished = true;
                                        return;
                                    }

                                    //The best way to parse this would be using the JSON info. I have not been able to do it. We will use RegExp instead
                                    //TODO: Parse this into string operation to gain performance.
                                    this.threatName = Regex.Match(responseUnparsed, @"threat_name"":""" + "(.+?)\"").Groups[1].Value;
                                    this.totalAV = Convert.ToInt32(Regex.Match(responseUnparsed, @"total_avs"":" + "(.+?),").Groups[1].Value);
                                    this.detectedAV = Convert.ToInt32(Regex.Match(responseUnparsed, @"total_detected_avs"":" + "(.+?),").Groups[1].Value);


                                    this.processFinished = true;
                                }
                                else
                                {
                                    this.processFinished = true;
                                    return;
                                }


                                Logger.Debug("Parsing from Hybrid-Analysis finished correctly");
                                return;
                            }
                            catch (Exception ex)
                            {
                                this.processFinished = true;
                                Logger.Error($"Error Parsing info from MetaDefender: {ex.StackTrace} - {ex.Message}");
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error parsing results from Metadefender: {ex.StackTrace} - {ex.Message}");
                this.processFinished = true;
            }
        }

    }
}
