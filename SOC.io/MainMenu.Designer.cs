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
            this.Index = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.fileAnalyzer = new System.Windows.Forms.Button();
            this.urlReputation = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.urlReputationPanel = new System.Windows.Forms.Panel();
            this.countryNameResponse = new System.Windows.Forms.Label();
            this.ispResponselabel = new System.Windows.Forms.Label();
            this.hostnameLabelResponse = new System.Windows.Forms.Label();
            this.ipLabelResponse = new System.Windows.Forms.Label();
            this.ispLabel = new System.Windows.Forms.Label();
            this.countryNameLabel = new System.Windows.Forms.Label();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.exportResultsButton = new System.Windows.Forms.Button();
            this.progressBarUrlReputation = new System.Windows.Forms.ProgressBar();
            this.abuseIPDBlabel = new System.Windows.Forms.Label();
            this.abuseIPDBgraph = new LiveCharts.WinForms.SolidGauge();
            this.urlReputationSearch = new System.Windows.Forms.Button();
            this.urlReputationTextbox = new System.Windows.Forms.TextBox();
            this.maltiverseGraph = new LiveCharts.WinForms.SolidGauge();
            this.urlScanGraph = new LiveCharts.WinForms.SolidGauge();
            this.maltiverseLabel = new System.Windows.Forms.Label();
            this.urlScanLabel = new System.Windows.Forms.Label();
            this.Index.SuspendLayout();
            this.urlReputationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Index
            // 
            this.Index.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.Index.Controls.Add(this.button2);
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
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Settings";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fileAnalyzer
            // 
            this.fileAnalyzer.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileAnalyzer.FlatAppearance.BorderSize = 0;
            this.fileAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileAnalyzer.Image = global::SOCio.Properties.Resources.malwarelogo;
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
            this.urlReputation.Image = global::SOCio.Properties.Resources.graphbarlogo;
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
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 100);
            this.Logo.TabIndex = 0;
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
            this.urlReputationPanel.Controls.Add(this.progressBarUrlReputation);
            this.urlReputationPanel.Controls.Add(this.abuseIPDBlabel);
            this.urlReputationPanel.Controls.Add(this.abuseIPDBgraph);
            this.urlReputationPanel.Controls.Add(this.urlReputationSearch);
            this.urlReputationPanel.Controls.Add(this.urlReputationTextbox);
            this.urlReputationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlReputationPanel.Location = new System.Drawing.Point(200, 0);
            this.urlReputationPanel.Name = "urlReputationPanel";
            this.urlReputationPanel.Size = new System.Drawing.Size(834, 581);
            this.urlReputationPanel.TabIndex = 1;
            this.urlReputationPanel.Visible = false;
            // 
            // countryNameResponse
            // 
            this.countryNameResponse.AutoSize = true;
            this.countryNameResponse.Location = new System.Drawing.Point(280, 65);
            this.countryNameResponse.Name = "countryNameResponse";
            this.countryNameResponse.Size = new System.Drawing.Size(0, 13);
            this.countryNameResponse.TabIndex = 16;
            // 
            // ispResponselabel
            // 
            this.ispResponselabel.AutoSize = true;
            this.ispResponselabel.Location = new System.Drawing.Point(283, 87);
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
            this.ispLabel.Location = new System.Drawing.Point(250, 87);
            this.ispLabel.Name = "ispLabel";
            this.ispLabel.Size = new System.Drawing.Size(27, 13);
            this.ispLabel.TabIndex = 12;
            this.ispLabel.Text = "ISP:";
            this.ispLabel.Visible = false;
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.AutoSize = true;
            this.countryNameLabel.Location = new System.Drawing.Point(202, 65);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(77, 13);
            this.countryNameLabel.TabIndex = 11;
            this.countryNameLabel.Text = "Country Name:";
            this.countryNameLabel.Visible = false;
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Location = new System.Drawing.Point(37, 87);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(58, 13);
            this.hostnameLabel.TabIndex = 10;
            this.hostnameLabel.Text = "Hostname:";
            this.hostnameLabel.Visible = false;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(75, 65);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(20, 13);
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
            // 
            // progressBarUrlReputation
            // 
            this.progressBarUrlReputation.Location = new System.Drawing.Point(369, 322);
            this.progressBarUrlReputation.Name = "progressBarUrlReputation";
            this.progressBarUrlReputation.Size = new System.Drawing.Size(100, 23);
            this.progressBarUrlReputation.TabIndex = 7;
            this.progressBarUrlReputation.Visible = false;
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
            // maltiverseGraph
            // 
            this.maltiverseGraph.Location = new System.Drawing.Point(474, 148);
            this.maltiverseGraph.Name = "maltiverseGraph";
            this.maltiverseGraph.Size = new System.Drawing.Size(259, 126);
            this.maltiverseGraph.TabIndex = 17;
            this.maltiverseGraph.Text = "Maltiverse";
            this.maltiverseGraph.Visible = false;
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
            // maltiverseLabel
            // 
            this.maltiverseLabel.AutoSize = true;
            this.maltiverseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maltiverseLabel.Location = new System.Drawing.Point(541, 288);
            this.maltiverseLabel.Name = "maltiverseLabel";
            this.maltiverseLabel.Size = new System.Drawing.Size(123, 29);
            this.maltiverseLabel.TabIndex = 19;
            this.maltiverseLabel.Text = "Maltiverse";
            this.maltiverseLabel.Visible = false;
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 581);
            this.Controls.Add(this.urlReputationPanel);
            this.Controls.Add(this.Index);
            this.Name = "MainMenu";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "SOC.io";
            this.Index.ResumeLayout(false);
            this.urlReputationPanel.ResumeLayout(false);
            this.urlReputationPanel.PerformLayout();
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
        public System.Windows.Forms.ProgressBar progressBarUrlReputation;
        public System.Windows.Forms.Button button2;
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
    }
}

