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

            this.Logger.Info("Starting program...");
            
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
        }


        private void deselectIndexButtons() {
            fileAnalyzer.BackColor = deselectedColor;
            urlReputation.BackColor = deselectedColor;
        }

        private void hidePanels() {
            urlReputationPanel.Visible = false;
        }


    }
}

