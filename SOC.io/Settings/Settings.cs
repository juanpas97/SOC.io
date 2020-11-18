using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SOCio.Settings
{
    public class SettingsMenu
    {

        #region Constants

        MainMenu form;
        public ILog Logger { get; set; }

        #endregion

        public SettingsMenu(MainMenu form) {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();
            
            //Eventos

            form.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);

            this.form = form;
            form.settingsPanel.Visible = true;
            form.settingsPanel.BringToFront();
            
            form.SettingsAbuseIPDBText.Text = ConfigurationManager.AppSettings["AbuseIPDB"];
            form.SettingsHybridAnalysisText.Text = ConfigurationManager.AppSettings["HybridAnalysis"];
            form.SettingsMetadefenderText.Text = ConfigurationManager.AppSettings["Metadefender"];
            form.saveLocationSettingsText.Text = ConfigurationManager.AppSettings["SaveLocation"];

        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            saveSettingsResults();
        }

        private void saveSettingsResults() {

            Configuration configuration =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            configuration.AppSettings.Settings["AbuseIPDB"].Value = form.SettingsAbuseIPDBText.Text;
            configuration.AppSettings.Settings["Metadefender"].Value = form.SettingsMetadefenderText.Text;
            configuration.AppSettings.Settings["HybridAnalysis"].Value = form.SettingsHybridAnalysisText.Text;
            configuration.AppSettings.Settings["SaveLocation"].Value = form.saveLocationSettingsText.Text;

            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");

            if (form.SettingsCrackerModeCheckBox.Checked == true)
            {
                form.sound.PlayLooping();
            }
            else {
                form.sound.Stop();
            }

        }
    }
}
