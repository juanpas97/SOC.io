using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCio.Analyze_file
{
    public class Analyze_File
    {
        #region Constants

        MainMenu form;
        public ILog Logger { get; set; }

        #endregion

        #region Variables

        private string md5;
        private string sha256;
        private string sha512;

        #endregion

        public Analyze_File(MainMenu form) {


            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();

            this.form = form;
            form.analyzeFilePanel.Visible = true;
            form.analyzeFilePanel.BringToFront();

            form.uploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
        }


        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadFile = new OpenFileDialog();
            uploadFile.InitialDirectory = @"C:\";
            uploadFile.ShowDialog();

            if (!string.IsNullOrEmpty(uploadFile.FileName)) {
                if (uploadFile.CheckFileExists && uploadFile.CheckPathExists) {
                    this.md5 = calculateMD5(uploadFile.FileName);
                    this.sha256 = calculateSHA256(uploadFile.FileName);
                    this.sha512 = calculateSHA512(uploadFile.FileName);



                    showResults();

                }
            }
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

    }
}
