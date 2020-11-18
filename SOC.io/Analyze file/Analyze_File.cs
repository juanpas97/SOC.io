using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace SOCio.Analyze_file
{
    public class Analyze_File
    {
        #region Constants

        MainMenu form;
        public ILog Logger { get; set; }

        #endregion

        #region Variables

        private string md5 = string.Empty;
        private string sha256 = string.Empty;
        private string sha512 = string.Empty;

        public HybridAnalysis hybridAnalysis;
        public Metadefender metadefender;

        #endregion

        public Analyze_File(MainMenu form) {


            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();

            this.form = form;
            form.analyzeFilePanel.Visible = true;
            form.analyzeFilePanel.BringToFront();

            form.uploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            form.analyzeFileButton.Click += new System.EventHandler(this.analyzeFileButton_Click);
            form.hybridAnalysisLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hybridAnalysisLink_LinkClicked);
            form.metadefenderLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.metadefenderLink_LinkClicked);
            form.saveResultAnalyzeButton.Click += new System.EventHandler(this.saveResultAnalyzeButton_Click);
        }


        private void UploadFileButton_Click(object sender, EventArgs e)
        {

            clearPanel();

            OpenFileDialog uploadFile = new OpenFileDialog();
            uploadFile.InitialDirectory = @"C:\";
            uploadFile.ShowDialog();


            if (!string.IsNullOrEmpty(uploadFile.FileName)) {
                if (uploadFile.CheckFileExists && uploadFile.CheckPathExists) {
                    this.md5 = calculateMD5(uploadFile.FileName);
                    this.sha256 = calculateSHA256(uploadFile.FileName);
                    this.sha512 = calculateSHA512(uploadFile.FileName);

                    form.analyzeFileButton.Visible = true;


                    showResults();

                }
            }
        }


        private void analyzeFileButton_Click(object sender, EventArgs e)
        {
            analyzeFile();
        }

        private string calculateMD5(string path) {
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        var hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            catch (Exception ex) {
                Logger.Error($"Error calculating MD5: {ex.StackTrace} - {ex.Message}");
                return string.Empty;
            }
        }

        private string calculateSHA256(string path) {
            try
            {
                using (var sha256 = SHA256.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        var hash = sha256.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            catch (Exception ex) {
                Logger.Error($"Error calculating SHA-256: {ex.StackTrace} - {ex.Message}");
                return string.Empty;
            }
        }

        private string calculateSHA512(string path) {
            try
            {
                using (var sha = SHA512.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        var hash = sha.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error calculating SHA-512: {ex.StackTrace} - {ex.Message}");
                return string.Empty;
            }
        }


        private void showResults()
        {
            form.md5Label.Visible = true;
            form.md5Text.Visible = true;
            form.md5Text.Text = this.md5;

            form.sha256Label.Visible = true;
            form.sha256Text.Visible = true;
            form.sha256Text.Text = this.sha256;

            form.sha512Label.Visible = true;
            form.sha512Text.Visible = true;
            form.sha512Text.Text = this.sha512;

            form.saveResultAnalyzeButton.Visible = true;

        }

        private void analyzeFile() {

            hybridAnalysis = new HybridAnalysis();
            metadefender = new Metadefender();
            //According to the Hybrid Analysis API, you can pass the hash in your preferred format.
            //There is no need to check the value as the value is always going to exist.

            Task.Factory.StartNew(() => hybridAnalysis.getResult(sha256));
            Task.Factory.StartNew(() => metadefender.getResult(sha256));

            do
            {
                //Waiting for the processes to finish

            } while (!hybridAnalysis.processFinished || !metadefender.processFinished);


            if (!hybridAnalysis.noResult)
            {
                showDataHybridAnalysis();
                createGraphHybridGraph();
            }
            else {
                form.noDataHybridAnalysis.Visible = true;
                form.hybridAnalysisLink.Visible = true;
            }
            if (!metadefender.noResult)
            {
                createMetadefenderGraph();
            }
            else {
                form.noDataMetadefenderLabel.Visible = true;
                form.metadefenderLink.Visible = true;

            }
        }


        #region Hybrid Analysis

        private void showDataHybridAnalysis() {
            try
            {
                form.hybridAnalysisLink.Visible = true;

                form.fileInfoLabel.Visible = true;

                form.categoriesUrlLabel.Visible = true;

                if (!string.IsNullOrEmpty(form.fileInfoText.Text)) {
                    form.fileInfoText.Text = hybridAnalysis.fileInfo;
                    form.fileInfoText.Visible = true;
                }

                form.virusFamilyLabel.Visible = true;

                if (!string.IsNullOrEmpty(form.virusFamilyText.Text))
                {
                    form.virusFamilyText.Text = hybridAnalysis.virusFamily;
                    form.virusFamilyText.Visible = true;
                }

                if (hybridAnalysis.tags.Count > 0) {

                    form.categoriesUrlText.Text = createStringCategories(hybridAnalysis.tags);
                    form.categoriesUrlText.Visible = true;
                }


            } catch (Exception ex) {
                Logger.Error($"Error presenting HybridAnalysis Info:{ex.StackTrace} - {ex.Message}");
            }
        }

        private string createStringCategories(List<string> categories) {
            string result = string.Empty;

            foreach (string cat in categories) {
                result += cat + ",";
            }

            return result;
        }

        private void createGraphHybridGraph() {
            try
            {
                if (hybridAnalysis.score == int.MinValue && hybridAnalysis.verdict == string.Empty)
                {
                    form.noDataHybridAnalysis.Visible = true;
                }
                else { 
                    form.hybridAnalysisLabel.Visible = true;
                    form.hybridAnalysisGraph.Visible = true;

                    form.hybridAnalysisGraph.From = 0;
                    form.hybridAnalysisGraph.To = 100;


                    form.hybridAnalysisGraph.ToColor = chooseColor(hybridAnalysis.score);

                    if (hybridAnalysis.score != int.MinValue)
                    {
                        form.hybridAnalysisGraph.Value = hybridAnalysis.score;
                    }
                    else
                    {

                        form.hybridAnalysisGraph.Value = parseResult(hybridAnalysis.verdict);
                    }
                }
            }
            catch (Exception ex) {
                Logger.Error($"Error creating Hybrid-Analysis Graph:{ex.StackTrace} - {ex.Message}" );
            }
        }

        public int parseResult(string verdict)
        {
            switch (verdict)
            {
                case "malicious":
                    return 100;
                case "suspicious":
                    return 60;
                case "neutral":
                    return 20;
                case "whitelisted":
                    return 0;
                default:
                    return 0;
            }

        }


        private void hybridAnalysisLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.hybrid-analysis.com/search?query=" + md5);
        }

        #endregion

        #region Metadefender

        private void createMetadefenderGraph() {
            try
            {

                form.metadefenderLabel.Visible = true;

                form.metaDefenderGraph.Visible = true;

                form.avDetectedLabel.Visible = true;

                form.metaDefenderGraph.From = 0;

                //The default is 37 because metadefender has 37 antivirus by default
                if (metadefender.totalAV == int.MinValue)
                {
                    form.metaDefenderGraph.To = 37;
                }
                else
                {
                    form.metaDefenderGraph.To = metadefender.totalAV;
                }

                form.hybridAnalysisGraph.ToColor = chooseColorMetaDefender(metadefender.totalAV, metadefender.detectedAV);

                form.metaDefenderGraph.Value = metadefender.detectedAV;

                form.metadefenderLink.Visible = true;
            }
            catch (Exception ex) {
                Logger.Error($"Error creating Metadefender graph: {ex.StackTrace} - {ex.Message}");
            }
        }

        private void metadefenderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://metadefender.opswat.com/results/file/{md5}/hash/multiscan?lang=en");
        }

        //This color will be different as the color will depend on the total percentage of the AVs.
        private System.Windows.Media.Color chooseColorMetaDefender(int totalAV, int detectedAV) {
            try
            {

                //We get the result 1000-based.
                int result = Convert.ToInt32((detectedAV / totalAV) * 100);

                System.Windows.Media.Color color;

                if (result > 0 && result <= 20)
                {
                    color = Colors.LimeGreen;
                }
                else if (result > 20 && result <= 60)
                {
                    color = Colors.Yellow;
                }
                else
                {
                    color = Colors.Red;
                }

                return color;
            }
            catch (Exception ex) {
                Logger.Error("Error parsing color for MetaDefender: " + ex.StackTrace + " - " + ex.Message);
                return Colors.LimeGreen;
            }

        }


        #endregion


        #region Export Results

        private void saveResultAnalyzeButton_Click(object sender, EventArgs e)
        {
            exportResultsFileAnalyzer();
        }

        private void exportResultsFileAnalyzer() {
            try
            {
                //First we will calculate the name of the file. To do this, we check if the file already exists.
                //If exists, we will follow the Windows format to add (int).
                string filePath = string.Empty;

                if (!string.IsNullOrEmpty(md5))
                {
                    filePath = ConfigurationManager.AppSettings["SaveLocation"] + md5;
                }
                else
                {
                     filePath = ConfigurationManager.AppSettings["SaveLocation"] + "AnalyzeFile";
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
                Logger.Error("Error exporting results from Analyze File:" + ex.StackTrace + " - " + ex.Message);
                MessageBox.Show("Error exporting image", "Error", MessageBoxButtons.OK);
            }
        }

        #endregion


        private System.Windows.Media.Color chooseColor(int score)
        {
            //Ther default color to show will be green. Nevertheless, this value can never be reached
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

            return result;
        }

        private void clearPanel() {

            form.analyzeFileButton.Visible = false;

            form.hybridAnalysisGraph.Visible = false;
            form.hybridAnalysisLabel.Visible = false;

            form.md5Text.Visible = false;
            form.sha256Text.Visible = false;
            form.sha512Text.Visible = false;

            form.hybridAnalysisLink.Visible = false;

        }
         
    }
}
