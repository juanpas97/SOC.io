using LiveCharts;
using log4net;
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

namespace SOCio.URL_Reputation
{
    public class URLScanIO
    {
        public ILog Logger { get; set; }

        public int score = int.MinValue;

        public List<string> categories;

        DateTime time;

        public URLScanIO() {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();
        }

        // TODO: Add the function for submitting an URL instead of using already existing ones. 
        public async Task getResult(string input)
        {
            try
            {
                //URLScan.IO works as following:
                // 1. We perform a scan to the url to see if it has already been scanned
                
                string uuid = string.Empty;
                string verdict = string.Empty;


                string responseUnparsed = string.Empty;

                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://urlscan.io/api/v1/search/?q=domain:" + parseURL(input)))
                    {
                        var response = await httpClient.SendAsync(request);

                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            responseUnparsed = response.Content.ReadAsStringAsync().Result;
                        }
                        else
                        {
                            Logger.Warn("Status code from URLScan.IO Search query is: " + response.StatusCode);
                            return;
                        }

                        try
                        {
                            if (!string.IsNullOrEmpty(responseUnparsed))
                            {
                                time = Convert.ToDateTime(Regex.Match(responseUnparsed, @"time"": """ + "(.+?)\",").Groups[1].Value);
                                uuid = Regex.Match(responseUnparsed, @"uuid"": """ + "(.+?)\",").Groups[1].Value;
                            }
                            else
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Error($"Error parsing information from URLScan.IO Search Query: {ex.StackTrace} - {ex.Message}");
                        }
                    }

                    //An example of malicious URL for URLScan.io is sis-research.com or www.halifax.pending-auth.com
                    // This is useful when debugging
                    if (!string.IsNullOrEmpty(uuid))
                    {

                        using (var request = new HttpRequestMessage(new HttpMethod("GET"), $"https://urlscan.io/api/v1/result/{uuid}/"))
                        {

                            var response = await httpClient.SendAsync(request);

                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                responseUnparsed = response.Content.ReadAsStringAsync().Result;
                            }
                            else
                            {
                                Logger.Warn("Status code from URLScan.IO RESULT query is: " + response.StatusCode);
                                return;
                            }

                            try
                            {
                                if (!string.IsNullOrEmpty(responseUnparsed))
                                {
                                    //This part is a bit tricky. As we are not able to parse the JSON, we will jast extract the following
                                    //part from the response:
                                    //"verdicts": {
                                    //"overall": {
                                    //    "score": 100,
                                    //"categories": [
                                    //  "phishing"
                                    //                                ],
                                    //"brands": [
                                    //  "microsoft"
                                    //                                ],
                                    //"tags": [
                                    //  "phishing"
                                    //                                ],
                                    //"malicious": true,
                                    //"hasVerdicts": 

                                    int index = responseUnparsed.IndexOf("verdicts");
                                    if (index > 0) {
                                        string parsed = responseUnparsed.Substring(index).Replace("\n", "").Replace("\r", ""); ;
                                        this.score = Convert.ToInt32(Regex.Match(responseUnparsed, @"score"": " + "(.+?),").Groups[1].Value);

                                        string categoriesUnparsed = Regex.Match(parsed, @"tags\"":" + "(.+?),").Groups[1].Value;
                                        this.categories = categoriesUnparsed.Replace("[","").Replace("]","").Replace("\"","").Replace(" ","").Split(new char[] { ',' }).ToList();
                                    }

                                }
                                else
                                {
                                    Logger.Error($"Error getting result from URLScan.IO");

                                }
                            }
                            catch (Exception ex)
                            {
                                Logger.Error($"Error parsing information from URLScan.IO Result query: {ex.StackTrace} - {ex.Message}");
                            }
                        }


                    }
                }
            }
            catch (Exception ex) {
                Logger.Error($"Error getting URLScan.IO Info: {ex.StackTrace} - {ex.Message}");
            }
        }


        private string parseURL(string input)
        {
            //URLScan.io presents several problems with their APIs. If you want to send an URL, it can't have http or https
            // Also, it only can parse the domain name, not differents paths. For example: www.google.com its valid, but not www.google.com/api/
            try
            {
                string inputParsed = string.Empty;

                Uri myUri = new Uri(input);
                string host = myUri.Host; 

                return host;
            }
            catch (Exception ex)
            {
                //If this fails, we will parse everything manually instead of using the System package
                Logger.Error("Error parsing URL for ScanURL.io: " + ex.StackTrace + " - " + ex.StackTrace);

                input = input.Replace("https://","").Replace("http://","");

                if (input.Contains("/")) {
                    int index = input.IndexOf('/');

                    input = input.Substring(0,index);

                }

                return input;
            }
        }


        public int parseResult()
        {
            if (score == int.MinValue)
            {
                return 0;
            }
            else {
                return score;
            }
        }
    }
}
