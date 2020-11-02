using LiveCharts;
using LiveCharts.Wpf;
using log4net;
using SOCio.URLReputation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace SOCio.URL_Reputation
{
    public class URLReputationMenu
    {
        MainMenu form;

        #region Constants

        public const string urlReputationDefaultText = "IP or hostname";
        public ILog Logger { get; set; }

        #endregion

        #region Variables

        AbuseIPDB abuseIPDB;
        Maltiverse maltiverse;
        URLScanIO urlscanio;

        #endregion

        public URLReputationMenu(MainMenu form) {
            this.form = form;
            form.urlReputationPanel.Visible = true;
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();

            form.urlReputationTextbox.Text = urlReputationDefaultText;

            form.urlReputationSearch.Click += new System.EventHandler(this.urlReputationSearch_Click);
            form.urlReputationTextbox.Enter += new System.EventHandler(this.urlReputationTextbox_Enter);
            form.exportResultsButton.Click += new System.EventHandler(this.exportResultsButton_Click);
            form.urlReputationTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlReputationTextbox_KeyDown);
        }

        private void urlReputationTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                PerformScans();
            }
        }

        private void urlReputationTextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(form.urlReputationTextbox.Text))
            {
                form.urlReputationTextbox.Text = "IP or hostname";
                form.urlReputationTextbox.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void urlReputationTextbox_Enter(object sender, EventArgs e)
        {
            if (form.urlReputationTextbox.Text.Equals(urlReputationDefaultText))
            {
                form.urlReputationTextbox.Text = "";
            }
        }


        private bool checkIP(string input)
        {
            IPAddress ip;

            if (IPAddress.TryParse(input, out ip))
            {
                switch (ip.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        return true;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        return true;
                    default:
                        return false;
                }
            }

            return false;

        }

        private bool checkHttp(string input)
        {
            //HTTP and HTTPs is accepted
            Uri uriResult;
            bool result = Uri.TryCreate(input, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }

        private bool checkURL(string input) {

            bool isUri = Uri.IsWellFormedUriString(input, UriKind.RelativeOrAbsolute);
            return isUri;
        }

        private void PerformScans() {

            string input = form.urlReputationTextbox.Text;

            Logger.Debug("The user's input is: " + input);

            if (!checkIP(input) && !checkHttp(input) && !checkURL(input))
            {
                MessageBox.Show("Insert a valid IP or hostname");
                return;
            }


            abuseIPDB = new AbuseIPDB();
            maltiverse = new Maltiverse();
            urlscanio = new URLScanIO();

            try
            {
                if (checkURL(input))
                {
                    Logger.Debug("Ther user wrote a hostname: " + input);
                    //IPHostEntry hostEntry;
                    //hostEntry = Dns.GetHostEntry(input);

                    System.Net.IPAddress[] addresses = System.Net.Dns.GetHostAddresses(input);

                    //After a DNS resolution, we can get more than 1 result. We will always us the first one. 
                    //If the user wants another IP, it can be written directly on the form.

                    //Task.Factory.StartNew(() => abuseIPDB.getResult(Convert.ToString(addresses[0])));
                    Task.Factory.StartNew(() => maltiverse.getResult("hostname", input));
                    //Task.Factory.StartNew(() => urlscanio.getResult(input));
                }
                else
                {
                    Logger.Debug("Ther user wrote an IP: " + input);
                    //Task.Factory.StartNew(() => abuseIPDB.getResult(input));
                    Task.Factory.StartNew(() => maltiverse.getResult("ip", input));
                }
            }
            catch (Exception ex) {
                Logger.Error($"Error creating async functions: {ex.StackTrace} - {ex.Message}" );
            }



            //Loading progress bar to wait for results
            if (abuseIPDB.abuseConfidenceScore == int.MinValue)
            {
                form.progressBarUrlReputation.Visible = true;

                while (abuseIPDB.abuseConfidenceScore == int.MinValue)
                {
                    form.progressBarUrlReputation.Value = 25;
                }
            }

            form.progressBarUrlReputation.Visible = false;

            showResults();
        }

        private void urlReputationSearch_Click(object sender, EventArgs e)
        {
            PerformScans(); 
        }


        private void showResults() {

            form.countryNameLabel.Visible = true;
            form.ispLabel.Visible = true;
            form.ipLabel.Visible = true;
            form.hostnameLabel.Visible = true;

            if (!string.IsNullOrEmpty(abuseIPDB.countryName))
            {  
                form.countryNameResponse.Text = abuseIPDB.countryName + ", " + abuseIPDB.countryCode;
            }
            if (!string.IsNullOrEmpty(abuseIPDB.isp))
            {
                form.ispResponselabel.Text = abuseIPDB.isp;
            }
            if (!string.IsNullOrEmpty(abuseIPDB.hostnames[0]))
            {
                form.hostnameLabelResponse.Text = abuseIPDB.hostnames[0];
            }
            if (!string.IsNullOrEmpty(abuseIPDB.ipAddress))
            {
                form.ipLabelResponse.Text = abuseIPDB.ipAddress;
            }

            createGraphAbuseIPDB();

            createGraphMaltiverse();

        }

        #region Abuse IPDB

        private void createGraphAbuseIPDB() {
            try
            {
                form.abuseIPDBgraph.Visible = true;
                form.abuseIPDBlabel.Visible = true;


                form.abuseIPDBgraph.From = 0;
                form.abuseIPDBgraph.To = 100;
                if (abuseIPDB.abuseConfidenceScore != 0)
                {
                    if (abuseIPDB.abuseConfidenceScore > 0 && abuseIPDB.abuseConfidenceScore <= 20)
                    {
                        form.abuseIPDBgraph.ToColor = Colors.LimeGreen;
                    }
                    else if (abuseIPDB.abuseConfidenceScore > 20 && abuseIPDB.abuseConfidenceScore <= 60)
                    {
                        form.abuseIPDBgraph.ToColor = Colors.Yellow;
                    }
                    else {
                        form.abuseIPDBgraph.ToColor = Colors.Red;
                    }
                    form.abuseIPDBgraph.Value = abuseIPDB.abuseConfidenceScore;
                }
                else {
                    form.abuseIPDBgraph.Value = 0;
                }
            }
            catch (Exception ex) {
                Logger.Error($"Error creating AbuseIPDBGraph: {ex.StackTrace} - {ex.Message}");
            }

        }

        #endregion

        #region Maltiverse

        private void createGraphMaltiverse()
        {
            try
            {
                form.maltiverseGraph.Visible = true;
                form.maltiverseGraph.Visible = true;


                form.maltiverseGraph.From = 0;
                form.maltiverseGraph.To = 100;
                if (maltiverse.parsedResult != 0)
                {
                    if (maltiverse.parsedResult > 0 && maltiverse.parsedResult <= 20)
                    {
                        form.maltiverseGraph.ToColor = Colors.LimeGreen;
                    }
                    else if (maltiverse.parsedResult > 20 && maltiverse.parsedResult <= 60)
                    {
                        form.maltiverseGraph.ToColor = Colors.Yellow;
                    }
                    else
                    {
                        form.maltiverseGraph.ToColor = Colors.Red;
                    }

                    form.maltiverseGraph.Value = maltiverse.parsedResult;
                }
                else
                {
                    form.maltiverseGraph.Value = 0;
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error creating Maltiverse Graph: {ex.StackTrace} - {ex.Message}");
            }

        }

        #endregion



        private void exportResultsButton_Click(object sender, EventArgs e)
        {
            Bitmap FormScreenShot = new Bitmap(form.Width, form.Height);

            Graphics G = Graphics.FromImage(FormScreenShot);

            G.CopyFromScreen(form.Location, new Point(0, 0), form.Size);

            Clipboard.SetImage(FormScreenShot);
        }
    }

}


 
