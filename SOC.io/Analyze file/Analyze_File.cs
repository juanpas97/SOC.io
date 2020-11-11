using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        HybridAnalysis hybridAnalysis;
        Metadefender metadefener;

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

        }

        private void analyzeFile() {

            hybridAnalysis = new HybridAnalysis();
            metadefener = new Metadefender();
            //According to the Hybrid Analysis API, you can pass the hash in your preferred format.
            //There is no need to check the value as the value is always going to exist.

            //Task.Factory.StartNew(() => hybridAnalysis.getResult(sha256));
            Task.Factory.StartNew(() => metadefener.getResult(sha256));

            while (!hybridAnalysis.processFinished && !metadefener.processFinished)
            {
                //Waiting for the process to finish
            }

            showDataHybridAnalysis();
            createGraphHybridAnalysis();
        }


        #region Hybrid Analysis

        private void showDataHybridAnalysis() {
            try
            {
                form.hybridAnalysisLink.Visible = true;

                form.fileInfoLabel.Visible = true;

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


            } catch (Exception ex) {
                Logger.Error($"Error presenting HybridAnalysis Info:{ex.StackTrace} - {ex.Message}");
            }
        }

        private void createGraphHybridAnalysis() {
            try
            {
                form.hybridAnalysisLabel.Visible = true;
                form.hybridAnalysisGraph.Visible = true;

                form.hybridAnalysisGraph.From = 0;
                form.hybridAnalysisGraph.To = 100;


                form.hybridAnalysisGraph.ToColor = chooseColor(hybridAnalysis.score);
                form.hybridAnalysisGraph.Value = hybridAnalysis.score;
            }
            catch (Exception ex) {
                Logger.Error($"Error creating Hybrid-Analysis Graph:{ex.StackTrace} - {ex.Message}" );
            }
        }


        private void hybridAnalysisLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.hybrid-analysis.com/search?query=" + md5);
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
