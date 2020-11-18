using System.Drawing;
using System.Media;

namespace SOCio
{
    public partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Index = new System.Windows.Forms.Panel();
            this.settingsIndex = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.fileAnalyzer = new System.Windows.Forms.Button();
            this.urlReputation = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.urlReputationPanel = new System.Windows.Forms.Panel();
            this.urlScanLabel = new System.Windows.Forms.Label();
            this.maltiverseLabel = new System.Windows.Forms.Label();
            this.urlScanGraph = new LiveCharts.WinForms.SolidGauge();
            this.maltiverseGraph = new LiveCharts.WinForms.SolidGauge();
            this.countryNameResponse = new System.Windows.Forms.Label();
            this.ispResponselabel = new System.Windows.Forms.Label();
            this.hostnameLabelResponse = new System.Windows.Forms.Label();
            this.ipLabelResponse = new System.Windows.Forms.Label();
            this.ispLabel = new System.Windows.Forms.Label();
            this.countryNameLabel = new System.Windows.Forms.Label();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.exportResultsButton = new System.Windows.Forms.Button();
            this.abuseIPDBlabel = new System.Windows.Forms.Label();
            this.abuseIPDBgraph = new LiveCharts.WinForms.SolidGauge();
            this.urlReputationSearch = new System.Windows.Forms.Button();
            this.urlReputationTextbox = new System.Windows.Forms.TextBox();
            this.noDataURLScanLabel = new System.Windows.Forms.TextBox();
            this.noDataMaltiverseLabel = new System.Windows.Forms.TextBox();
            this.noDataAbuseIPDBLabel = new System.Windows.Forms.TextBox();
            this.analyzeFilePanel = new System.Windows.Forms.Panel();
            this.categoriesUrlText = new System.Windows.Forms.Label();
            this.categoriesUrlLabel = new System.Windows.Forms.Label();
            this.saveResultAnalyzeButton = new System.Windows.Forms.Button();
            this.avDetectedLabel = new System.Windows.Forms.Label();
            this.metadefenderLink = new System.Windows.Forms.LinkLabel();
            this.metadefenderLabel = new System.Windows.Forms.Label();
            this.metaDefenderGraph = new LiveCharts.WinForms.SolidGauge();
            this.virusFamilyText = new System.Windows.Forms.Label();
            this.virusFamilyLabel = new System.Windows.Forms.Label();
            this.fileInfoText = new System.Windows.Forms.Label();
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.hybridAnalysisLink = new System.Windows.Forms.LinkLabel();
            this.hybridAnalysisLabel = new System.Windows.Forms.Label();
            this.hybridAnalysisGraph = new LiveCharts.WinForms.SolidGauge();
            this.analyzeFileButton = new System.Windows.Forms.Button();
            this.sha512Text = new System.Windows.Forms.TextBox();
            this.sha256Text = new System.Windows.Forms.TextBox();
            this.md5Text = new System.Windows.Forms.TextBox();
            this.sha512Label = new System.Windows.Forms.Label();
            this.sha256Label = new System.Windows.Forms.Label();
            this.md5Label = new System.Windows.Forms.Label();
            this.uploadFileButton = new System.Windows.Forms.Button();
            this.noDataHybridAnalysis = new System.Windows.Forms.TextBox();
            this.noDataMetadefenderLabel = new System.Windows.Forms.TextBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.mainLogo = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.APIKeysWarning = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.saveLocationSettingsText = new System.Windows.Forms.TextBox();
            this.saveLocationSettingsLabel = new System.Windows.Forms.Label();
            this.SettingsHybridAnalysisText = new System.Windows.Forms.TextBox();
            this.SettingsMetadefenderText = new System.Windows.Forms.TextBox();
            this.SettingsAbuseIPDBText = new System.Windows.Forms.TextBox();
            this.SettingsGeneralSettingsLabel = new System.Windows.Forms.Label();
            this.SettingsCrackerModeCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingsHybridAnalysisAPILabel = new System.Windows.Forms.Label();
            this.SettingsMetadefenderAPILabel = new System.Windows.Forms.Label();
            this.SettingsAbuseIPDBAPILabel = new System.Windows.Forms.Label();
            this.SettingsapiKeysLabel = new System.Windows.Forms.Label();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.contact = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Index.SuspendLayout();
            this.Logo.SuspendLayout();
            this.urlReputationPanel.SuspendLayout();
            this.analyzeFilePanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Index
            // 
            this.Index.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.Index.Controls.Add(this.settingsIndex);
            this.Index.Controls.Add(this.about);
            this.Index.Controls.Add(this.fileAnalyzer);
            this.Index.Controls.Add(this.urlReputation);
            this.Index.Controls.Add(this.Logo);
            this.Index.Dock = System.Windows.Forms.DockStyle.Left;
            this.Index.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Index.Location = new System.Drawing.Point(0, 0);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(200, 581);
            this.Index.TabIndex = 0;
            // 
            // settingsIndex
            // 
            this.settingsIndex.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsIndex.FlatAppearance.BorderSize = 0;
            this.settingsIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsIndex.Image = ((System.Drawing.Image)(resources.GetObject("settingsIndex.Image")));
            this.settingsIndex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsIndex.Location = new System.Drawing.Point(0, 485);
            this.settingsIndex.Name = "settingsIndex";
            this.settingsIndex.Size = new System.Drawing.Size(200, 48);
            this.settingsIndex.TabIndex = 4;
            this.settingsIndex.Text = "Settings";
            this.settingsIndex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsIndex.UseVisualStyleBackColor = true;
            this.settingsIndex.Click += new System.EventHandler(this.settings_Click);
            // 
            // about
            // 
            this.about.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Location = new System.Drawing.Point(0, 533);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(200, 48);
            this.about.TabIndex = 3;
            this.about.Text = "About";
            this.about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // fileAnalyzer
            // 
            this.fileAnalyzer.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileAnalyzer.FlatAppearance.BorderSize = 0;
            this.fileAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileAnalyzer.Image = ((System.Drawing.Image)(resources.GetObject("fileAnalyzer.Image")));
            this.fileAnalyzer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileAnalyzer.Location = new System.Drawing.Point(0, 148);
            this.fileAnalyzer.Name = "fileAnalyzer";
            this.fileAnalyzer.Size = new System.Drawing.Size(200, 48);
            this.fileAnalyzer.TabIndex = 2;
            this.fileAnalyzer.Text = "Analyze file";
            this.fileAnalyzer.UseVisualStyleBackColor = true;
            this.fileAnalyzer.Click += new System.EventHandler(this.fileAnalyzer_Click);
            // 
            // urlReputation
            // 
            this.urlReputation.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlReputation.FlatAppearance.BorderSize = 0;
            this.urlReputation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urlReputation.Image = ((System.Drawing.Image)(resources.GetObject("urlReputation.Image")));
            this.urlReputation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urlReputation.Location = new System.Drawing.Point(0, 100);
            this.urlReputation.Name = "urlReputation";
            this.urlReputation.Size = new System.Drawing.Size(200, 48);
            this.urlReputation.TabIndex = 1;
            this.urlReputation.Text = "URL Reputation";
            this.urlReputation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.urlReputation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.urlReputation.UseVisualStyleBackColor = true;
            this.urlReputation.Click += new System.EventHandler(this.urlReputation_Click);
            // 
            // Logo
            // 
            this.Logo.Controls.Add(this.homeButton);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 100);
            this.Logo.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(200, 100);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // urlReputationPanel
            // 
            this.urlReputationPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.urlReputationPanel.Controls.Add(this.urlScanLabel);
            this.urlReputationPanel.Controls.Add(this.maltiverseLabel);
            this.urlReputationPanel.Controls.Add(this.urlScanGraph);
            this.urlReputationPanel.Controls.Add(this.maltiverseGraph);
            this.urlReputationPanel.Controls.Add(this.countryNameResponse);
            this.urlReputationPanel.Controls.Add(this.ispResponselabel);
            this.urlReputationPanel.Controls.Add(this.hostnameLabelResponse);
            this.urlReputationPanel.Controls.Add(this.ipLabelResponse);
            this.urlReputationPanel.Controls.Add(this.ispLabel);
            this.urlReputationPanel.Controls.Add(this.countryNameLabel);
            this.urlReputationPanel.Controls.Add(this.hostnameLabel);
            this.urlReputationPanel.Controls.Add(this.ipLabel);
            this.urlReputationPanel.Controls.Add(this.exportResultsButton);
            this.urlReputationPanel.Controls.Add(this.abuseIPDBlabel);
            this.urlReputationPanel.Controls.Add(this.abuseIPDBgraph);
            this.urlReputationPanel.Controls.Add(this.urlReputationSearch);
            this.urlReputationPanel.Controls.Add(this.urlReputationTextbox);
            this.urlReputationPanel.Controls.Add(this.noDataURLScanLabel);
            this.urlReputationPanel.Controls.Add(this.noDataMaltiverseLabel);
            this.urlReputationPanel.Controls.Add(this.noDataAbuseIPDBLabel);
            this.urlReputationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlReputationPanel.Location = new System.Drawing.Point(200, 0);
            this.urlReputationPanel.Name = "urlReputationPanel";
            this.urlReputationPanel.Size = new System.Drawing.Size(834, 581);
            this.urlReputationPanel.TabIndex = 1;
            this.urlReputationPanel.Visible = false;
            // 
            // urlScanLabel
            // 
            this.urlScanLabel.AutoSize = true;
            this.urlScanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlScanLabel.Location = new System.Drawing.Point(129, 503);
            this.urlScanLabel.Name = "urlScanLabel";
            this.urlScanLabel.Size = new System.Drawing.Size(145, 29);
            this.urlScanLabel.TabIndex = 20;
            this.urlScanLabel.Text = "URLScan.IO";
            this.urlScanLabel.Visible = false;
            // 
            // maltiverseLabel
            // 
            this.maltiverseLabel.AutoSize = true;
            this.maltiverseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maltiverseLabel.Location = new System.Drawing.Point(547, 288);
            this.maltiverseLabel.Name = "maltiverseLabel";
            this.maltiverseLabel.Size = new System.Drawing.Size(123, 29);
            this.maltiverseLabel.TabIndex = 19;
            this.maltiverseLabel.Text = "Maltiverse";
            this.maltiverseLabel.Visible = false;
            // 
            // urlScanGraph
            // 
            this.urlScanGraph.Location = new System.Drawing.Point(78, 374);
            this.urlScanGraph.Name = "urlScanGraph";
            this.urlScanGraph.Size = new System.Drawing.Size(259, 126);
            this.urlScanGraph.TabIndex = 18;
            this.urlScanGraph.Text = "URLScan.io";
            this.urlScanGraph.Visible = false;
            // 
            // maltiverseGraph
            // 
            this.maltiverseGraph.Location = new System.Drawing.Point(474, 148);
            this.maltiverseGraph.Name = "maltiverseGraph";
            this.maltiverseGraph.Size = new System.Drawing.Size(259, 126);
            this.maltiverseGraph.TabIndex = 17;
            this.maltiverseGraph.Text = "Maltiverse";
            this.maltiverseGraph.Visible = false;
            // 
            // countryNameResponse
            // 
            this.countryNameResponse.AutoSize = true;
            this.countryNameResponse.Location = new System.Drawing.Point(349, 65);
            this.countryNameResponse.Name = "countryNameResponse";
            this.countryNameResponse.Size = new System.Drawing.Size(0, 13);
            this.countryNameResponse.TabIndex = 16;
            // 
            // ispResponselabel
            // 
            this.ispResponselabel.AutoSize = true;
            this.ispResponselabel.Location = new System.Drawing.Point(352, 87);
            this.ispResponselabel.Name = "ispResponselabel";
            this.ispResponselabel.Size = new System.Drawing.Size(0, 13);
            this.ispResponselabel.TabIndex = 15;
            // 
            // hostnameLabelResponse
            // 
            this.hostnameLabelResponse.AutoSize = true;
            this.hostnameLabelResponse.Location = new System.Drawing.Point(101, 87);
            this.hostnameLabelResponse.Name = "hostnameLabelResponse";
            this.hostnameLabelResponse.Size = new System.Drawing.Size(0, 13);
            this.hostnameLabelResponse.TabIndex = 14;
            // 
            // ipLabelResponse
            // 
            this.ipLabelResponse.AutoSize = true;
            this.ipLabelResponse.Location = new System.Drawing.Point(102, 65);
            this.ipLabelResponse.Name = "ipLabelResponse";
            this.ipLabelResponse.Size = new System.Drawing.Size(0, 13);
            this.ipLabelResponse.TabIndex = 13;
            // 
            // ispLabel
            // 
            this.ispLabel.AutoSize = true;
            this.ispLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ispLabel.Location = new System.Drawing.Point(308, 87);
            this.ispLabel.Name = "ispLabel";
            this.ispLabel.Size = new System.Drawing.Size(31, 13);
            this.ispLabel.TabIndex = 12;
            this.ispLabel.Text = "ISP:";
            this.ispLabel.Visible = false;
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.AutoSize = true;
            this.countryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryNameLabel.Location = new System.Drawing.Point(249, 65);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(90, 13);
            this.countryNameLabel.TabIndex = 11;
            this.countryNameLabel.Text = "Country Name:";
            this.countryNameLabel.Visible = false;
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostnameLabel.Location = new System.Drawing.Point(37, 87);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(67, 13);
            this.hostnameLabel.TabIndex = 10;
            this.hostnameLabel.Text = "Hostname:";
            this.hostnameLabel.Visible = false;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.Location = new System.Drawing.Point(80, 65);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(23, 13);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "IP:";
            this.ipLabel.Visible = false;
            // 
            // exportResultsButton
            // 
            this.exportResultsButton.Location = new System.Drawing.Point(721, 23);
            this.exportResultsButton.Name = "exportResultsButton";
            this.exportResultsButton.Size = new System.Drawing.Size(83, 23);
            this.exportResultsButton.TabIndex = 8;
            this.exportResultsButton.Text = "Export Results";
            this.exportResultsButton.UseVisualStyleBackColor = true;
            this.exportResultsButton.Visible = false;
            // 
            // abuseIPDBlabel
            // 
            this.abuseIPDBlabel.AutoSize = true;
            this.abuseIPDBlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abuseIPDBlabel.Location = new System.Drawing.Point(129, 288);
            this.abuseIPDBlabel.Name = "abuseIPDBlabel";
            this.abuseIPDBlabel.Size = new System.Drawing.Size(136, 29);
            this.abuseIPDBlabel.TabIndex = 6;
            this.abuseIPDBlabel.Text = "AbuseIPDB";
            this.abuseIPDBlabel.Visible = false;
            // 
            // abuseIPDBgraph
            // 
            this.abuseIPDBgraph.Location = new System.Drawing.Point(65, 148);
            this.abuseIPDBgraph.Name = "abuseIPDBgraph";
            this.abuseIPDBgraph.Size = new System.Drawing.Size(259, 126);
            this.abuseIPDBgraph.TabIndex = 5;
            this.abuseIPDBgraph.Text = "AbuseIPDB";
            this.abuseIPDBgraph.Visible = false;
            // 
            // urlReputationSearch
            // 
            this.urlReputationSearch.Location = new System.Drawing.Point(629, 23);
            this.urlReputationSearch.Name = "urlReputationSearch";
            this.urlReputationSearch.Size = new System.Drawing.Size(75, 23);
            this.urlReputationSearch.TabIndex = 4;
            this.urlReputationSearch.Text = "Search";
            this.urlReputationSearch.UseVisualStyleBackColor = true;
            // 
            // urlReputationTextbox
            // 
            this.urlReputationTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.urlReputationTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlReputationTextbox.Location = new System.Drawing.Point(29, 23);
            this.urlReputationTextbox.Name = "urlReputationTextbox";
            this.urlReputationTextbox.Size = new System.Drawing.Size(594, 20);
            this.urlReputationTextbox.TabIndex = 3;
            // 
            // noDataURLScanLabel
            // 
            this.noDataURLScanLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noDataURLScanLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noDataURLScanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataURLScanLabel.Location = new System.Drawing.Point(109, 450);
            this.noDataURLScanLabel.Multiline = true;
            this.noDataURLScanLabel.Name = "noDataURLScanLabel";
            this.noDataURLScanLabel.Size = new System.Drawing.Size(215, 84);
            this.noDataURLScanLabel.TabIndex = 21;
            this.noDataURLScanLabel.Text = "No data provided from\r\n URLScan.IO";
            this.noDataURLScanLabel.Visible = false;
            // 
            // noDataMaltiverseLabel
            // 
            this.noDataMaltiverseLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noDataMaltiverseLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noDataMaltiverseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataMaltiverseLabel.Location = new System.Drawing.Point(501, 212);
            this.noDataMaltiverseLabel.Multiline = true;
            this.noDataMaltiverseLabel.Name = "noDataMaltiverseLabel";
            this.noDataMaltiverseLabel.Size = new System.Drawing.Size(215, 84);
            this.noDataMaltiverseLabel.TabIndex = 22;
            this.noDataMaltiverseLabel.Text = "No data provided from\r Maltiverse";
            this.noDataMaltiverseLabel.Visible = false;
            // 
            // noDataAbuseIPDBLabel
            // 
            this.noDataAbuseIPDBLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noDataAbuseIPDBLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noDataAbuseIPDBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataAbuseIPDBLabel.Location = new System.Drawing.Point(111, 223);
            this.noDataAbuseIPDBLabel.Multiline = true;
            this.noDataAbuseIPDBLabel.Name = "noDataAbuseIPDBLabel";
            this.noDataAbuseIPDBLabel.Size = new System.Drawing.Size(215, 84);
            this.noDataAbuseIPDBLabel.TabIndex = 23;
            this.noDataAbuseIPDBLabel.Text = "No data provided from\r AbuseIPDB";
            this.noDataAbuseIPDBLabel.Visible = false;
            // 
            // analyzeFilePanel
            // 
            this.analyzeFilePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.analyzeFilePanel.Controls.Add(this.categoriesUrlText);
            this.analyzeFilePanel.Controls.Add(this.categoriesUrlLabel);
            this.analyzeFilePanel.Controls.Add(this.saveResultAnalyzeButton);
            this.analyzeFilePanel.Controls.Add(this.avDetectedLabel);
            this.analyzeFilePanel.Controls.Add(this.metadefenderLink);
            this.analyzeFilePanel.Controls.Add(this.metadefenderLabel);
            this.analyzeFilePanel.Controls.Add(this.metaDefenderGraph);
            this.analyzeFilePanel.Controls.Add(this.virusFamilyText);
            this.analyzeFilePanel.Controls.Add(this.virusFamilyLabel);
            this.analyzeFilePanel.Controls.Add(this.fileInfoText);
            this.analyzeFilePanel.Controls.Add(this.fileInfoLabel);
            this.analyzeFilePanel.Controls.Add(this.hybridAnalysisLink);
            this.analyzeFilePanel.Controls.Add(this.hybridAnalysisLabel);
            this.analyzeFilePanel.Controls.Add(this.hybridAnalysisGraph);
            this.analyzeFilePanel.Controls.Add(this.analyzeFileButton);
            this.analyzeFilePanel.Controls.Add(this.sha512Text);
            this.analyzeFilePanel.Controls.Add(this.sha256Text);
            this.analyzeFilePanel.Controls.Add(this.md5Text);
            this.analyzeFilePanel.Controls.Add(this.sha512Label);
            this.analyzeFilePanel.Controls.Add(this.sha256Label);
            this.analyzeFilePanel.Controls.Add(this.md5Label);
            this.analyzeFilePanel.Controls.Add(this.uploadFileButton);
            this.analyzeFilePanel.Controls.Add(this.noDataHybridAnalysis);
            this.analyzeFilePanel.Controls.Add(this.noDataMetadefenderLabel);
            this.analyzeFilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analyzeFilePanel.Location = new System.Drawing.Point(200, 0);
            this.analyzeFilePanel.Name = "analyzeFilePanel";
            this.analyzeFilePanel.Size = new System.Drawing.Size(834, 581);
            this.analyzeFilePanel.TabIndex = 21;
            this.analyzeFilePanel.Visible = false;
            // 
            // categoriesUrlText
            // 
            this.categoriesUrlText.AutoSize = true;
            this.categoriesUrlText.Location = new System.Drawing.Point(273, 533);
            this.categoriesUrlText.Name = "categoriesUrlText";
            this.categoriesUrlText.Size = new System.Drawing.Size(90, 13);
            this.categoriesUrlText.TabIndex = 24;
            this.categoriesUrlText.Text = "categoriesUrlText";
            this.categoriesUrlText.Visible = false;
            // 
            // categoriesUrlLabel
            // 
            this.categoriesUrlLabel.AutoSize = true;
            this.categoriesUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesUrlLabel.Location = new System.Drawing.Point(191, 531);
            this.categoriesUrlLabel.Name = "categoriesUrlLabel";
            this.categoriesUrlLabel.Size = new System.Drawing.Size(71, 13);
            this.categoriesUrlLabel.TabIndex = 23;
            this.categoriesUrlLabel.Text = "Categories:";
            this.categoriesUrlLabel.Visible = false;
            // 
            // saveResultAnalyzeButton
            // 
            this.saveResultAnalyzeButton.Location = new System.Drawing.Point(111, 148);
            this.saveResultAnalyzeButton.Name = "saveResultAnalyzeButton";
            this.saveResultAnalyzeButton.Size = new System.Drawing.Size(75, 23);
            this.saveResultAnalyzeButton.TabIndex = 20;
            this.saveResultAnalyzeButton.Text = "Save Result";
            this.saveResultAnalyzeButton.UseVisualStyleBackColor = true;
            this.saveResultAnalyzeButton.Visible = false;
            // 
            // avDetectedLabel
            // 
            this.avDetectedLabel.AutoSize = true;
            this.avDetectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avDetectedLabel.Location = new System.Drawing.Point(571, 380);
            this.avDetectedLabel.Name = "avDetectedLabel";
            this.avDetectedLabel.Size = new System.Drawing.Size(93, 16);
            this.avDetectedLabel.TabIndex = 19;
            this.avDetectedLabel.Text = "AV detected";
            this.avDetectedLabel.Visible = false;
            // 
            // metadefenderLink
            // 
            this.metadefenderLink.AutoSize = true;
            this.metadefenderLink.Location = new System.Drawing.Point(578, 434);
            this.metadefenderLink.Name = "metadefenderLink";
            this.metadefenderLink.Size = new System.Drawing.Size(71, 13);
            this.metadefenderLink.TabIndex = 18;
            this.metadefenderLink.TabStop = true;
            this.metadefenderLink.Text = "Check Online";
            this.metadefenderLink.Visible = false;
            // 
            // metadefenderLabel
            // 
            this.metadefenderLabel.AutoSize = true;
            this.metadefenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metadefenderLabel.Location = new System.Drawing.Point(496, 393);
            this.metadefenderLabel.Name = "metadefenderLabel";
            this.metadefenderLabel.Size = new System.Drawing.Size(233, 29);
            this.metadefenderLabel.TabIndex = 17;
            this.metadefenderLabel.Text = "Metadefender Cloud";
            this.metadefenderLabel.Visible = false;
            // 
            // metaDefenderGraph
            // 
            this.metaDefenderGraph.Location = new System.Drawing.Point(490, 227);
            this.metaDefenderGraph.Name = "metaDefenderGraph";
            this.metaDefenderGraph.Size = new System.Drawing.Size(250, 152);
            this.metaDefenderGraph.TabIndex = 16;
            this.metaDefenderGraph.Text = "solidGauge1";
            this.metaDefenderGraph.Visible = false;
            // 
            // virusFamilyText
            // 
            this.virusFamilyText.AutoSize = true;
            this.virusFamilyText.Location = new System.Drawing.Point(273, 505);
            this.virusFamilyText.Name = "virusFamilyText";
            this.virusFamilyText.Size = new System.Drawing.Size(62, 13);
            this.virusFamilyText.TabIndex = 15;
            this.virusFamilyText.Text = "FileInfoText";
            this.virusFamilyText.Visible = false;
            // 
            // virusFamilyLabel
            // 
            this.virusFamilyLabel.AutoSize = true;
            this.virusFamilyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virusFamilyLabel.Location = new System.Drawing.Point(187, 505);
            this.virusFamilyLabel.Name = "virusFamilyLabel";
            this.virusFamilyLabel.Size = new System.Drawing.Size(75, 13);
            this.virusFamilyLabel.TabIndex = 14;
            this.virusFamilyLabel.Text = "Virus family:";
            this.virusFamilyLabel.Visible = false;
            // 
            // fileInfoText
            // 
            this.fileInfoText.AutoSize = true;
            this.fileInfoText.Location = new System.Drawing.Point(273, 475);
            this.fileInfoText.Name = "fileInfoText";
            this.fileInfoText.Size = new System.Drawing.Size(62, 13);
            this.fileInfoText.TabIndex = 13;
            this.fileInfoText.Text = "FileInfoText";
            this.fileInfoText.Visible = false;
            // 
            // fileInfoLabel
            // 
            this.fileInfoLabel.AutoSize = true;
            this.fileInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInfoLabel.Location = new System.Drawing.Point(205, 475);
            this.fileInfoLabel.Name = "fileInfoLabel";
            this.fileInfoLabel.Size = new System.Drawing.Size(57, 13);
            this.fileInfoLabel.TabIndex = 12;
            this.fileInfoLabel.Text = "File Info:";
            this.fileInfoLabel.Visible = false;
            // 
            // hybridAnalysisLink
            // 
            this.hybridAnalysisLink.AutoSize = true;
            this.hybridAnalysisLink.Location = new System.Drawing.Point(159, 434);
            this.hybridAnalysisLink.Name = "hybridAnalysisLink";
            this.hybridAnalysisLink.Size = new System.Drawing.Size(71, 13);
            this.hybridAnalysisLink.TabIndex = 11;
            this.hybridAnalysisLink.TabStop = true;
            this.hybridAnalysisLink.Text = "Check Online";
            this.hybridAnalysisLink.Visible = false;
            // 
            // hybridAnalysisLabel
            // 
            this.hybridAnalysisLabel.AutoSize = true;
            this.hybridAnalysisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hybridAnalysisLabel.Location = new System.Drawing.Point(112, 393);
            this.hybridAnalysisLabel.Name = "hybridAnalysisLabel";
            this.hybridAnalysisLabel.Size = new System.Drawing.Size(179, 29);
            this.hybridAnalysisLabel.TabIndex = 10;
            this.hybridAnalysisLabel.Text = "Hybrid-Analysis";
            this.hybridAnalysisLabel.Visible = false;
            // 
            // hybridAnalysisGraph
            // 
            this.hybridAnalysisGraph.Location = new System.Drawing.Point(71, 227);
            this.hybridAnalysisGraph.Name = "hybridAnalysisGraph";
            this.hybridAnalysisGraph.Size = new System.Drawing.Size(250, 152);
            this.hybridAnalysisGraph.TabIndex = 9;
            this.hybridAnalysisGraph.Text = "solidGauge1";
            this.hybridAnalysisGraph.Visible = false;
            // 
            // analyzeFileButton
            // 
            this.analyzeFileButton.Location = new System.Drawing.Point(29, 148);
            this.analyzeFileButton.Name = "analyzeFileButton";
            this.analyzeFileButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeFileButton.TabIndex = 8;
            this.analyzeFileButton.Text = "Analyze File";
            this.analyzeFileButton.UseVisualStyleBackColor = true;
            this.analyzeFileButton.Visible = false;
            // 
            // sha512Text
            // 
            this.sha512Text.Location = new System.Drawing.Point(103, 106);
            this.sha512Text.Name = "sha512Text";
            this.sha512Text.ReadOnly = true;
            this.sha512Text.Size = new System.Drawing.Size(694, 20);
            this.sha512Text.TabIndex = 7;
            this.sha512Text.Visible = false;
            // 
            // sha256Text
            // 
            this.sha256Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sha256Text.Location = new System.Drawing.Point(103, 78);
            this.sha256Text.Name = "sha256Text";
            this.sha256Text.ReadOnly = true;
            this.sha256Text.Size = new System.Drawing.Size(694, 20);
            this.sha256Text.TabIndex = 6;
            this.sha256Text.Visible = false;
            // 
            // md5Text
            // 
            this.md5Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.md5Text.Location = new System.Drawing.Point(103, 51);
            this.md5Text.Name = "md5Text";
            this.md5Text.ReadOnly = true;
            this.md5Text.Size = new System.Drawing.Size(694, 20);
            this.md5Text.TabIndex = 5;
            this.md5Text.Visible = false;
            // 
            // sha512Label
            // 
            this.sha512Label.AutoSize = true;
            this.sha512Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha512Label.Location = new System.Drawing.Point(26, 107);
            this.sha512Label.Name = "sha512Label";
            this.sha512Label.Size = new System.Drawing.Size(72, 16);
            this.sha512Label.TabIndex = 4;
            this.sha512Label.Text = "SHA-512:";
            this.sha512Label.Visible = false;
            // 
            // sha256Label
            // 
            this.sha256Label.AutoSize = true;
            this.sha256Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha256Label.Location = new System.Drawing.Point(26, 80);
            this.sha256Label.Name = "sha256Label";
            this.sha256Label.Size = new System.Drawing.Size(72, 16);
            this.sha256Label.TabIndex = 3;
            this.sha256Label.Text = "SHA-256:";
            this.sha256Label.Visible = false;
            // 
            // md5Label
            // 
            this.md5Label.AutoSize = true;
            this.md5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.md5Label.Location = new System.Drawing.Point(49, 52);
            this.md5Label.Name = "md5Label";
            this.md5Label.Size = new System.Drawing.Size(48, 16);
            this.md5Label.TabIndex = 2;
            this.md5Label.Text = "MD-5:";
            this.md5Label.Visible = false;
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.Location = new System.Drawing.Point(29, 12);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(75, 23);
            this.uploadFileButton.TabIndex = 1;
            this.uploadFileButton.Text = "Load File";
            this.uploadFileButton.UseVisualStyleBackColor = true;
            // 
            // noDataHybridAnalysis
            // 
            this.noDataHybridAnalysis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noDataHybridAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noDataHybridAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataHybridAnalysis.Location = new System.Drawing.Point(92, 313);
            this.noDataHybridAnalysis.Multiline = true;
            this.noDataHybridAnalysis.Name = "noDataHybridAnalysis";
            this.noDataHybridAnalysis.Size = new System.Drawing.Size(271, 109);
            this.noDataHybridAnalysis.TabIndex = 21;
            this.noDataHybridAnalysis.Text = "No data provided \r\nfrom Hybrid-Analysis";
            this.noDataHybridAnalysis.Visible = false;
            // 
            // noDataMetadefenderLabel
            // 
            this.noDataMetadefenderLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noDataMetadefenderLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noDataMetadefenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataMetadefenderLabel.Location = new System.Drawing.Point(521, 313);
            this.noDataMetadefenderLabel.Multiline = true;
            this.noDataMetadefenderLabel.Name = "noDataMetadefenderLabel";
            this.noDataMetadefenderLabel.Size = new System.Drawing.Size(271, 109);
            this.noDataMetadefenderLabel.TabIndex = 22;
            this.noDataMetadefenderLabel.Text = "No data provided \r\nfrom Metadefender";
            this.noDataMetadefenderLabel.Visible = false;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homePanel.Controls.Add(this.mainLogo);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(200, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(834, 581);
            this.homePanel.TabIndex = 23;
            // 
            // mainLogo
            // 
            this.mainLogo.Enabled = false;
            this.mainLogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainLogo.FlatAppearance.BorderSize = 0;
            this.mainLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(52, 163);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(752, 245);
            this.mainLogo.TabIndex = 0;
            this.mainLogo.UseVisualStyleBackColor = true;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingsPanel.Controls.Add(this.APIKeysWarning);
            this.settingsPanel.Controls.Add(this.saveSettingsButton);
            this.settingsPanel.Controls.Add(this.saveLocationSettingsText);
            this.settingsPanel.Controls.Add(this.saveLocationSettingsLabel);
            this.settingsPanel.Controls.Add(this.SettingsHybridAnalysisText);
            this.settingsPanel.Controls.Add(this.SettingsMetadefenderText);
            this.settingsPanel.Controls.Add(this.SettingsAbuseIPDBText);
            this.settingsPanel.Controls.Add(this.SettingsGeneralSettingsLabel);
            this.settingsPanel.Controls.Add(this.SettingsCrackerModeCheckBox);
            this.settingsPanel.Controls.Add(this.SettingsHybridAnalysisAPILabel);
            this.settingsPanel.Controls.Add(this.SettingsMetadefenderAPILabel);
            this.settingsPanel.Controls.Add(this.SettingsAbuseIPDBAPILabel);
            this.settingsPanel.Controls.Add(this.SettingsapiKeysLabel);
            this.settingsPanel.Location = new System.Drawing.Point(199, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(834, 581);
            this.settingsPanel.TabIndex = 20;
            // 
            // APIKeysWarning
            // 
            this.APIKeysWarning.AutoSize = true;
            this.APIKeysWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APIKeysWarning.Location = new System.Drawing.Point(495, 26);
            this.APIKeysWarning.Name = "APIKeysWarning";
            this.APIKeysWarning.Size = new System.Drawing.Size(276, 25);
            this.APIKeysWarning.TabIndex = 12;
            this.APIKeysWarning.Text = "Never share your API Keys!";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettingsButton.Location = new System.Drawing.Point(353, 519);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 34);
            this.saveSettingsButton.TabIndex = 11;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // saveLocationSettingsText
            // 
            this.saveLocationSettingsText.Location = new System.Drawing.Point(170, 268);
            this.saveLocationSettingsText.Name = "saveLocationSettingsText";
            this.saveLocationSettingsText.Size = new System.Drawing.Size(601, 20);
            this.saveLocationSettingsText.TabIndex = 10;
            // 
            // saveLocationSettingsLabel
            // 
            this.saveLocationSettingsLabel.AutoSize = true;
            this.saveLocationSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocationSettingsLabel.Location = new System.Drawing.Point(31, 268);
            this.saveLocationSettingsLabel.Name = "saveLocationSettingsLabel";
            this.saveLocationSettingsLabel.Size = new System.Drawing.Size(122, 20);
            this.saveLocationSettingsLabel.TabIndex = 9;
            this.saveLocationSettingsLabel.Text = "Save location:";
            // 
            // SettingsHybridAnalysisText
            // 
            this.SettingsHybridAnalysisText.Location = new System.Drawing.Point(170, 140);
            this.SettingsHybridAnalysisText.Name = "SettingsHybridAnalysisText";
            this.SettingsHybridAnalysisText.Size = new System.Drawing.Size(601, 20);
            this.SettingsHybridAnalysisText.TabIndex = 8;
            // 
            // SettingsMetadefenderText
            // 
            this.SettingsMetadefenderText.Location = new System.Drawing.Point(170, 104);
            this.SettingsMetadefenderText.Name = "SettingsMetadefenderText";
            this.SettingsMetadefenderText.Size = new System.Drawing.Size(601, 20);
            this.SettingsMetadefenderText.TabIndex = 7;
            // 
            // SettingsAbuseIPDBText
            // 
            this.SettingsAbuseIPDBText.Location = new System.Drawing.Point(170, 69);
            this.SettingsAbuseIPDBText.Name = "SettingsAbuseIPDBText";
            this.SettingsAbuseIPDBText.Size = new System.Drawing.Size(601, 20);
            this.SettingsAbuseIPDBText.TabIndex = 6;
            // 
            // SettingsGeneralSettingsLabel
            // 
            this.SettingsGeneralSettingsLabel.AutoSize = true;
            this.SettingsGeneralSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsGeneralSettingsLabel.Location = new System.Drawing.Point(33, 217);
            this.SettingsGeneralSettingsLabel.Name = "SettingsGeneralSettingsLabel";
            this.SettingsGeneralSettingsLabel.Size = new System.Drawing.Size(192, 25);
            this.SettingsGeneralSettingsLabel.TabIndex = 5;
            this.SettingsGeneralSettingsLabel.Text = "General settings:";
            // 
            // SettingsCrackerModeCheckBox
            // 
            this.SettingsCrackerModeCheckBox.AutoSize = true;
            this.SettingsCrackerModeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsCrackerModeCheckBox.Location = new System.Drawing.Point(317, 434);
            this.SettingsCrackerModeCheckBox.Name = "SettingsCrackerModeCheckBox";
            this.SettingsCrackerModeCheckBox.Size = new System.Drawing.Size(166, 29);
            this.SettingsCrackerModeCheckBox.TabIndex = 4;
            this.SettingsCrackerModeCheckBox.Text = "Cracker Mode";
            this.SettingsCrackerModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsHybridAnalysisAPILabel
            // 
            this.SettingsHybridAnalysisAPILabel.AutoSize = true;
            this.SettingsHybridAnalysisAPILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsHybridAnalysisAPILabel.Location = new System.Drawing.Point(23, 140);
            this.SettingsHybridAnalysisAPILabel.Name = "SettingsHybridAnalysisAPILabel";
            this.SettingsHybridAnalysisAPILabel.Size = new System.Drawing.Size(137, 20);
            this.SettingsHybridAnalysisAPILabel.TabIndex = 3;
            this.SettingsHybridAnalysisAPILabel.Text = "Hybrid-Analysis:";
            // 
            // SettingsMetadefenderAPILabel
            // 
            this.SettingsMetadefenderAPILabel.AutoSize = true;
            this.SettingsMetadefenderAPILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsMetadefenderAPILabel.Location = new System.Drawing.Point(34, 104);
            this.SettingsMetadefenderAPILabel.Name = "SettingsMetadefenderAPILabel";
            this.SettingsMetadefenderAPILabel.Size = new System.Drawing.Size(126, 20);
            this.SettingsMetadefenderAPILabel.TabIndex = 2;
            this.SettingsMetadefenderAPILabel.Text = "Metadefender:";
            // 
            // SettingsAbuseIPDBAPILabel
            // 
            this.SettingsAbuseIPDBAPILabel.AutoSize = true;
            this.SettingsAbuseIPDBAPILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsAbuseIPDBAPILabel.Location = new System.Drawing.Point(53, 69);
            this.SettingsAbuseIPDBAPILabel.Name = "SettingsAbuseIPDBAPILabel";
            this.SettingsAbuseIPDBAPILabel.Size = new System.Drawing.Size(107, 20);
            this.SettingsAbuseIPDBAPILabel.TabIndex = 1;
            this.SettingsAbuseIPDBAPILabel.Text = "AbuseIPDB:";
            // 
            // SettingsapiKeysLabel
            // 
            this.SettingsapiKeysLabel.AutoSize = true;
            this.SettingsapiKeysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsapiKeysLabel.Location = new System.Drawing.Point(26, 26);
            this.SettingsapiKeysLabel.Name = "SettingsapiKeysLabel";
            this.SettingsapiKeysLabel.Size = new System.Drawing.Size(114, 25);
            this.SettingsapiKeysLabel.TabIndex = 0;
            this.SettingsapiKeysLabel.Text = "API Keys:";
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aboutPanel.Controls.Add(this.githubLink);
            this.aboutPanel.Controls.Add(this.contact);
            this.aboutPanel.Controls.Add(this.credits);
            this.aboutPanel.Controls.Add(this.button1);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutPanel.Location = new System.Drawing.Point(200, 0);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(834, 581);
            this.aboutPanel.TabIndex = 24;
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(313, 488);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(149, 13);
            this.githubLink.TabIndex = 3;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "https://github.com/juanpas97";
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(34, 488);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(276, 13);
            this.contact.TabIndex = 2;
            this.contact.Text = "For any contact, please check my GitHub links:";
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.Location = new System.Drawing.Point(31, 459);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(254, 13);
            this.credits.TabIndex = 1;
            this.credits.Text = "This product is proudly made by Juan Perez";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(52, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(752, 245);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 581);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.analyzeFilePanel);
            this.Controls.Add(this.urlReputationPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.Index);
            this.Name = "MainMenu";
            this.Text = "SOC.io";
            this.Index.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            this.urlReputationPanel.ResumeLayout(false);
            this.urlReputationPanel.PerformLayout();
            this.analyzeFilePanel.ResumeLayout(false);
            this.analyzeFilePanel.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Index;
        public System.Windows.Forms.Button urlReputation;
        public System.Windows.Forms.Panel Logo;
        public System.Windows.Forms.Panel urlReputationPanel;
        public System.Windows.Forms.Button fileAnalyzer;
        public System.Windows.Forms.TextBox urlReputationTextbox;
        public System.Windows.Forms.Button urlReputationSearch;
        public LiveCharts.WinForms.SolidGauge abuseIPDBgraph;
        public System.Windows.Forms.Label abuseIPDBlabel;
        public System.Windows.Forms.Button about;
        public System.Windows.Forms.Button exportResultsButton;
        public System.Windows.Forms.Label countryNameResponse;
        public System.Windows.Forms.Label ispResponselabel;
        public System.Windows.Forms.Label hostnameLabelResponse;
        public System.Windows.Forms.Label ipLabelResponse;
        public System.Windows.Forms.Label ispLabel;
        public System.Windows.Forms.Label countryNameLabel;
        public System.Windows.Forms.Label hostnameLabel;
        public System.Windows.Forms.Label ipLabel;
        public System.Windows.Forms.Label urlScanLabel;
        public System.Windows.Forms.Label maltiverseLabel;
        public LiveCharts.WinForms.SolidGauge urlScanGraph;
        public LiveCharts.WinForms.SolidGauge maltiverseGraph;
        public System.Windows.Forms.Panel analyzeFilePanel;
        public System.Windows.Forms.Button uploadFileButton;
        public System.Windows.Forms.Label sha512Label;
        public System.Windows.Forms.Label sha256Label;
        public System.Windows.Forms.Label md5Label;
        public System.Windows.Forms.TextBox sha512Text;
        public System.Windows.Forms.TextBox sha256Text;
        public System.Windows.Forms.TextBox md5Text;
        public System.Windows.Forms.Button analyzeFileButton;
        public LiveCharts.WinForms.SolidGauge hybridAnalysisGraph;
        public System.Windows.Forms.Label hybridAnalysisLabel;
        public System.Windows.Forms.LinkLabel hybridAnalysisLink;
        public System.Windows.Forms.Label fileInfoText;
        public System.Windows.Forms.Label fileInfoLabel;
        public System.Windows.Forms.Label virusFamilyText;
        public System.Windows.Forms.Label virusFamilyLabel;
        public System.Windows.Forms.LinkLabel metadefenderLink;
        public System.Windows.Forms.Label metadefenderLabel;
        public LiveCharts.WinForms.SolidGauge metaDefenderGraph;
        public System.Windows.Forms.Label avDetectedLabel;
        public System.Windows.Forms.Button settingsIndex;
        public System.Windows.Forms.Panel settingsPanel;
        public System.Windows.Forms.Label SettingsAbuseIPDBAPILabel;
        public System.Windows.Forms.Label SettingsapiKeysLabel;
        public System.Windows.Forms.Label SettingsHybridAnalysisAPILabel;
        public System.Windows.Forms.Label SettingsMetadefenderAPILabel;
        public System.Windows.Forms.Label SettingsGeneralSettingsLabel;
        public System.Windows.Forms.CheckBox SettingsCrackerModeCheckBox;
        public System.Windows.Forms.TextBox SettingsHybridAnalysisText;
        public System.Windows.Forms.TextBox SettingsMetadefenderText;
        public System.Windows.Forms.TextBox SettingsAbuseIPDBText;
        public System.Windows.Forms.Button saveResultAnalyzeButton;
        public System.Windows.Forms.TextBox saveLocationSettingsText;
        public System.Windows.Forms.Label saveLocationSettingsLabel;
        public System.Windows.Forms.Button saveSettingsButton;
        public System.Windows.Forms.Label APIKeysWarning;
        public System.Windows.Forms.TextBox noDataHybridAnalysis;
        public System.Windows.Forms.TextBox noDataMetadefenderLabel;
        public System.Windows.Forms.Panel homePanel;
        public System.Windows.Forms.TextBox noDataURLScanLabel;
        public System.Windows.Forms.TextBox noDataMaltiverseLabel;
        public System.Windows.Forms.TextBox noDataAbuseIPDBLabel;
        public System.Windows.Forms.Button homeButton;
        public System.Windows.Forms.Button mainLogo;

        public SoundPlayer sound = new SoundPlayer(Properties.Resources.crackermusic);
        public System.Windows.Forms.Label categoriesUrlLabel;
        public System.Windows.Forms.Label categoriesUrlText;
        public System.Windows.Forms.Panel aboutPanel;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.LinkLabel githubLink;
        public System.Windows.Forms.Label contact;
        public System.Windows.Forms.Label credits;
    }
}

