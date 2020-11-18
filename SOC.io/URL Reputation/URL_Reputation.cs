using LiveCharts;
using LiveCharts.Wpf;
using log4net;
using SOCio.URLReputation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
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


        #region Constants

        MainMenu form;
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
            form.urlReputationPanel.BringToFront();
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
                form.exportResultsButton.Visible = true;
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

            clearPanel();

            string input = form.urlReputationTextbox.Text.Replace(" ","");

            Logger.Debug("The user's input is: " + input);

            if ((!checkIP(input) && !checkHttp(input) && !checkURL(input)) || string.IsNullOrEmpty(form.urlReputation.Text))
            {
                MessageBox.Show("Insert a valid IP or hostname");
                return;
            }

            //212.64.29.136
            abuseIPDB = new AbuseIPDB();
            maltiverse = new Maltiverse();
            urlscanio = new URLScanIO();

            try
            {
                if (!checkIP(input))
                {
                    if (checkURL(input))
                    {
                        Logger.Debug("Ther user wrote a hostname: " + input);
                        //IPHostEntry hostEntry;
                        //hostEntry = Dns.GetHostEntry(input);

                        System.Net.IPAddress[] addresses = System.Net.Dns.GetHostAddresses(input);

                        //After a DNS resolution, we can get more than 1 result. We will always us the first one. 
                        //If the user wants another IP, it can be written directly on the form.

                        Task.Factory.StartNew(() => abuseIPDB.getResult(Convert.ToString(addresses[0])));
                        Task.Factory.StartNew(() => maltiverse.getResult("hostname", input));
                        Task.Factory.StartNew(() => urlscanio.getResult("domain", input));
                    }
                }
                else
                {
                    Logger.Debug("Ther user wrote an IP: " + input);
                    Task.Factory.StartNew(() => abuseIPDB.getResult(input));
                    Task.Factory.StartNew(() => maltiverse.getResult("ip", input));
                    Task.Factory.StartNew(() => urlscanio.getResult("ip", input));
                }
            }
            catch (Exception ex) {
                Logger.Error($"Error creating async functions: {ex.StackTrace} - {ex.Message}" );
            }



            //Loading progress bar to wait for results
            while (abuseIPDB.processFinished == false || maltiverse.processFinished == false || urlscanio.processFinished == false)
            {

            }

            showResults();
        }

        private void urlReputationSearch_Click(object sender, EventArgs e)
        {
            PerformScans();
            form.exportResultsButton.Visible = true;
        }


        private void showResults() {

            form.countryNameLabel.Visible = true;
            form.ispLabel.Visible = true;
            form.ipLabel.Visible = true;
            form.hostnameLabel.Visible = true;

            if (!string.IsNullOrEmpty(abuseIPDB.countryName))
            {  
                form.countryNameResponse.Text = abuseIPDB.countryName + ", " + abuseIPDB.countryCode;
                form.countryNameResponse.Visible = true;
            }
            if (!string.IsNullOrEmpty(abuseIPDB.isp))
            {
                form.ispResponselabel.Text = abuseIPDB.isp;
                form.ispResponselabel.Visible = true;
            }
            if (abuseIPDB.hostnames.Count > 0)
            {
                if (!string.IsNullOrEmpty(abuseIPDB.hostnames[0]))
                {
                    form.hostnameLabelResponse.Text = abuseIPDB.hostnames[0];
                    form.hostnameLabelResponse.Visible = true;
                }
            }
            if (!string.IsNullOrEmpty(abuseIPDB.ipAddress))
            {
                form.ipLabelResponse.Text = abuseIPDB.ipAddress;
                form.ipLabelResponse.Visible = true;
            }

            createGraphAbuseIPDB();

            createGraphMaltiverse();

            createGraphURLScanIO();

        }

        #region Abuse IPDB

        private void createGraphAbuseIPDB() {
            try
            {
                if (abuseIPDB.abuseConfidenceScore == int.MinValue) {
                    form.noDataAbuseIPDBLabel.Visible = true;
                }


                form.abuseIPDBgraph.Visible = true;
                form.abuseIPDBlabel.Visible = true;

                form.abuseIPDBgraph.From = 0;
                form.abuseIPDBgraph.To = 100;
                if (abuseIPDB.abuseConfidenceScore != 0)
                {
                    form.abuseIPDBgraph.ToColor = choosecolor(abuseIPDB.abuseConfidenceScore);  
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
            if (string.IsNullOrEmpty(maltiverse.classification)) {
                form.noDataMaltiverseLabel.Visible = true;
                return;
            }

            try
            {
                form.maltiverseGraph.Visible = true;
                form.maltiverseLabel.Visible = true;


                form.maltiverseGraph.From = 0;
                form.maltiverseGraph.To = 100;
                if (maltiverse.parsedResult != 0)
                {
                    form.maltiverseGraph.ToColor = choosecolor(maltiverse.parsedResult);

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

        #region URLScan.IO

        private void createGraphURLScanIO() {
            try
            {
                if (urlscanio.score == int.MinValue)
                {
                    form.noDataURLScanLabel.Visible = true;
                    return;
                }

                    form.urlScanGraph.Visible = true;
                    form.urlScanLabel.Visible = true;


                    form.urlScanGraph.From = 0;
                    form.urlScanGraph.To = 100;
                    if (urlscanio.score != 0)
                    {

                        form.urlScanGraph.ToColor = choosecolor(urlscanio.score);
                        form.urlScanGraph.Value = urlscanio.score;
                    }
                    else
                    {
                        form.urlScanGraph.Value = 0;
                    }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error creating URLScan.IO Graph: {ex.StackTrace} - {ex.Message}");
            }

        }

        #endregion

        private System.Windows.Media.Color choosecolor(int score)
        {

            System.Windows.Media.Color result;

            if (score > 0 && score <= 20)
            {
                result = Colors.LimeGreen;
            }
            else if (score > 20 && score <= 60)
            {
                result = Colors.Yellow;
            }
            else
            {
                result = Colors.Red;
            }

            //Ther default color to show will be green. Nevertheless, this value can never be reached
            return result;
        }


        private void clearPanel() {

            form.maltiverseGraph.Visible = false;
            form.maltiverseLabel.Visible = false;

            form.urlScanLabel.Visible = false;
            form.urlScanGraph.Visible = false;

            form.abuseIPDBgraph.Visible = false;
            form.abuseIPDBlabel.Visible = false;

            form.countryNameLabel.Visible = false;
            form.ispLabel.Visible = false;
            form.ipLabel.Visible = false;
            form.hostnameLabel.Visible = false;

            form.ipLabelResponse.Visible = false;
            form.hostnameLabelResponse.Visible = false;
            form.ispResponselabel.Visible = false;
            form.countryNameResponse.Visible = false;

        }



        private void exportResultsButton_Click(object sender, EventArgs e)
        {
            exportResultsURLReputation();
        }

        private void exportResultsURLReputation() {
                try
                {
                    //First we will calculate the name of the file. To do this, we check if the file already exists.
                    //If exists, we will follow the Windows format to add (int).

                    string filePath = string.Empty;

                    if (!string.IsNullOrEmpty(form.urlReputationTextbox.Text))
                    {
                        filePath = ConfigurationManager.AppSettings["SaveLocation"] + form.urlReputationTextbox.Text;
                    }
                    else {
                        filePath = ConfigurationManager.AppSettings["SaveLocation"] + "URL_Reputation";
                    }
                    
                    var exists = true;
                    int i = 1;
                    while (exists)
                    {

                        var fileExists = File.Exists(filePath + ".png") ? true : false;
                        if (fileExists)
                        {
                            filePath = filePath + $" ({i})";
                        }
                        else
                        {
                            exists = false;
                        }
                    }


                    Bitmap bmp = new Bitmap(form.analyzeFilePanel.Width, form.analyzeFilePanel.Height);
                    form.analyzeFilePanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    using (MemoryStream memory = new MemoryStream())
                    {
                        //The file will be saved with the name of the MD5.
                        using (FileStream fs = new FileStream(filePath + ".png", FileMode.Create, FileAccess.ReadWrite))
                        {
                            bmp.Save(memory, ImageFormat.Jpeg);
                            byte[] bytes = memory.ToArray();
                            fs.Write(bytes, 0, bytes.Length);
                        }
                    }

                    Clipboard.SetImage(bmp);
                }
                catch (Exception ex)
                {
                    Logger.Error("Error exporting results from URL Reputation:" + ex.StackTrace + " - " + ex.Message);
                    MessageBox.Show("Error exporting image", "Error", MessageBoxButtons.OK);
                }
            }
    }
}


 
