using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SOCio.URL_Reputation
{
    public class URLScanIO
    {
        public ILog Logger { get; set; }

        public URLScanIO() {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();
        }

        // TODO: Add the function for submitting an URL instead of using already existing ones. 
        public async Task getResult(string input)
        {
            string apiKey = ConfigurationManager.AppSettings["URLScan.io"]; ;
            string responseUnparsed = string.Empty;

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://urlscan.io/api/v1/scan/"))
                {
                    request.Headers.TryAddWithoutValidation("API-Key", apiKey);

                    request.Content = new StringContent("{\"url\": \"www.google.com\", \"visibility\": \"public\"}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }


    }
}
