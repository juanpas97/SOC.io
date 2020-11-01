using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SOCio.URL_Reputation
{
    public class Maltiverse
    {
        public ILog Logger { get; set; }

        string classification = string.Empty;


        public Maltiverse() {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();
        }

        //The web resource can be either "ip" or "hostname"
        public async Task getResult(string webResource, string input) {

            string responseUnparsed = string.Empty;

            using (var request = new HttpRequestMessage())
            {
                var httpClient = new HttpClient();
                request.RequestUri = new Uri("https://api.maltiverse.com/"+  webResource + "/" + input);
                request.Method = HttpMethod.Get;

                using (var response = await httpClient.SendAsync(request))
                {

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        responseUnparsed = response.Content.ReadAsStringAsync().Result;

                        // Maltiverse can return the following categories: [ malicious, suspicious, neutral, whitelisted ]
                        //Source: https://app.swaggerhub.com/apis-docs/maltiverse/api/1.0.0-oas3#/IPv4/getIP
                        try
                        {
                            this.classification = Regex.Match(responseUnparsed, @"classification"": """ + "(.+?)\",").Groups[1].Value;
                        }
                        catch (Exception ex) {

                            Logger.Error($"Error parsing response from Maltiverse: {ex.StackTrace} - {ex.Message}");

                        }

                    }
                    else
                    {
                        Logger.Error($"Status code from Maltiverse is: " + response.StatusCode);
                        return;
                    }

                }
            }
        }
    }
}
