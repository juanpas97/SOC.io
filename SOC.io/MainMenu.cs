using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using SOCio.URL_Reputation;
using SOCio.Analyze_file;
using SOCio.Settings;
using System.Diagnostics;

namespace SOCio
{
    public partial class MainMenu : Form
    {

     

        #region Constants

        public ILog Logger { get; set; }

        #endregion

        #region Variables

        Color selectedColorPanel = Color.FromArgb(71, 71, 135);
        Color selectedColor = Color.FromArgb(71, 71, 135);
        Color deselectedColor = Color.FromArgb(64, 64, 122);


        #endregion

        public MainMenu()
        {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();

            this.Icon = Properties.Resources.icon;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            urlReputationTextbox.ForeColor = Color.LightGray;
        }

        private void urlReputation_Click(object sender, EventArgs e)
        {
            hidePanels();
            deselectIndexButtons();
            urlReputation.BackColor = selectedColor;
            URLReputationMenu urlreputation = new URLReputationMenu(this);
        }


        private void fileAnalyzer_Click(object sender, EventArgs e)
        {
            hidePanels();
            deselectIndexButtons();
            fileAnalyzer.BackColor = selectedColor;
            Analyze_File fileAnalyzerPanel = new Analyze_File(this);
        }


        private void deselectIndexButtons() {
            fileAnalyzer.BackColor = deselectedColor;
            urlReputation.BackColor = deselectedColor;
            settingsIndex.BackColor = deselectedColor;
        }

        private void hidePanels() {
            urlReputationPanel.Visible = false;
            analyzeFilePanel.Visible = false;
            settingsPanel.Visible = false;
            homePanel.Visible = false;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            hidePanels();
            deselectIndexButtons();
            settingsIndex.BackColor = selectedColor;
            SettingsMenu settings = new SettingsMenu(this);
        }

    }
}

