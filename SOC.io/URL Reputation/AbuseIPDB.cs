using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Collections.Specialized;
using log4net;
using System.Reflection;
using System.Net;
using System.Text.RegularExpressions;

namespace SOCio.URLReputation
{
    class AbuseIPDB
    {

        public int abuseConfidenceScore = int.MinValue;
        public string ipAddress;
        public string countryName;
        public string countryCode;
        public string domain;
        public string isp;
        public int totalReports = int.MinValue;
        public List<string> hostnames = new List<string>();

        public bool processFinished = false;

        public ILog Logger { get; set; }

        public AbuseIPDB() {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();
        }

        public async Task getResult(string input) {

            Logger.Info("Getting Info from AbuseIPDB");

            string url = "https://api.abuseipdb.com/api/v2/check?ipAddress=%URL%&maxAgeInDays=90&verbose";
            url = url.Replace("%URL%", input);

            string apiKey = ConfigurationManager.AppSettings["AbuseIPDB"];

            string responseUnparsed = string.Empty;

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"),url))
                {

                    try
                    {
                        request.Headers.TryAddWithoutValidation("Key", apiKey);
                        request.Headers.TryAddWithoutValidation("Accept", "application/json");

                        var response = await httpClient.SendAsync(request);


                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                           responseUnparsed = response.Content.ReadAsStringAsync().Result;
                        }
                        else {
                            Logger.Warn("Status from AbuseIPDB is: " + response.StatusCode);
                            processFinished = true;
                            return;
                        }
                    }
                    catch (Exception ex) {
                        Logger.Error($"Error getting info from AbuseIPDB: {ex.StackTrace} - {ex.Message}");
                        processFinished = true;
                        return;
                    }
                    try
                    {
                        if (!string.IsNullOrEmpty(responseUnparsed))
                        {
                            //The best way to parse this would be using the JSON info. I have not been able to do it. We will use RegExp instead
                            //TODO: Parse this into string operation to gain performance.
                            this.ipAddress = Regex.Match(responseUnparsed, @"ipAddress"":""" + "(.+?)\"").Groups[1].Value;
                            this.abuseConfidenceScore = Convert.ToInt32(Regex.Match(responseUnparsed, @"abuseConfidenceScore"":" +"(.+?),").Groups[1].Value);
                            this.countryName = Regex.Match(responseUnparsed, @"countryName"":""" + "(.+?)\"").Groups[1].Value;
                            this.countryCode = Regex.Match(responseUnparsed, @"countryCode"":""" + "(.+?)\"").Groups[1].Value;
                            this.isp = Regex.Match(responseUnparsed, @"isp"":""" + "(.+?)\"").Groups[1].Value;
                            this.domain = Regex.Match(responseUnparsed, @"domain"":""" + "(.+?)\"").Groups[1].Value;
                            this.totalReports = Convert.ToInt32(Regex.Match(responseUnparsed, @"totalReports"":" + "(.+?),").Groups[1].Value);
                            string hostnamesUnparsed = Regex.Match(responseUnparsed, @"hostnames"":\[" + @"(.+?)""\]").Groups[1].Value;
                            this.hostnames = hostnamesUnparsed.Replace("\"","").Split(',').ToList();
                        }
                        else {
                            processFinished = true;
                            return;
                        }

                        processFinished = true;
                        Logger.Debug("Parsing from AbuseIPDB finished correctly");
                        return;
                    }
                    catch (Exception ex) {
                        processFinished = true;
                        Logger.Error($"Error Parsing info from AbuseIPDB: {ex.StackTrace} - {ex.Message}");
                        return;
                    }
                }
            }

          }
    }
}
