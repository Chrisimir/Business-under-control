namespace Business_under_control
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.lblAlertNum = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblFirmName = new System.Windows.Forms.Label();
            this.flPaneOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lstSearchResults = new System.Windows.Forms.ListBox();
            this.paneAlert = new System.Windows.Forms.Panel();
            this.alertImage = new System.Windows.Forms.PictureBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblEditFirm = new System.Windows.Forms.Label();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.firmLogo = new System.Windows.Forms.PictureBox();
            this.flPaneOptions.SuspendLayout();
            this.paneAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Location = new System.Drawing.Point(26, 166);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(150, 49);
            this.btnStatistics.TabIndex = 0;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(26, 66);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(150, 49);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(26, 266);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(150, 49);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // lblAlertNum
            // 
            this.lblAlertNum.AutoSize = true;
            this.lblAlertNum.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertNum.ForeColor = System.Drawing.Color.Red;
            this.lblAlertNum.Location = new System.Drawing.Point(82, 20);
            this.lblAlertNum.Name = "lblAlertNum";
            this.lblAlertNum.Size = new System.Drawing.Size(17, 16);
            this.lblAlertNum.TabIndex = 2;
            this.lblAlertNum.Text = "0";
            this.lblAlertNum.Click += new System.EventHandler(this.openAlertWindow);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(153, 52);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(84, 18);
            this.lblAlert.TabIndex = 0;
            this.lblAlert.Text = "No alert.";
            this.lblAlert.Click += new System.EventHandler(this.openAlertWindow);
            // 
            // lblFirmName
            // 
            this.lblFirmName.AutoSize = true;
            this.lblFirmName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmName.Location = new System.Drawing.Point(797, 172);
            this.lblFirmName.MaximumSize = new System.Drawing.Size(120, 0);
            this.lblFirmName.Name = "lblFirmName";
            this.lblFirmName.Size = new System.Drawing.Size(98, 36);
            this.lblFirmName.TabIndex = 5;
            this.lblFirmName.Text = "Restaurant Denmark";
            this.lblFirmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flPaneOptions
            // 
            this.flPaneOptions.Controls.Add(this.btnAbout);
            this.flPaneOptions.Controls.Add(this.btnExit);
            this.flPaneOptions.Location = new System.Drawing.Point(750, 417);
            this.flPaneOptions.Name = "flPaneOptions";
            this.flPaneOptions.Size = new System.Drawing.Size(160, 70);
            this.flPaneOptions.TabIndex = 6;
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Image = global::Business_under_control.Properties.Resources.info;
            this.btnAbout.Location = new System.Drawing.Point(0, 0);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(80, 70);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = global::Business_under_control.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(80, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 70);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(432, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 23);
            this.textBox1.TabIndex = 7;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(357, 83);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(69, 18);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search:";
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSearchResults.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchResults.FormattingEnabled = true;
            this.lstSearchResults.IntegralHeight = false;
            this.lstSearchResults.ItemHeight = 16;
            this.lstSearchResults.Items.AddRange(new object[] {
            "160; 176",
            "160; 176",
            "160; 176",
            "160; 176",
            "160; 176",
            "160; 176",
            "160; 176",
            "160; 176",
            "eeeetssooot",
            "eeeetssooot",
            "eeeetssooot",
            "eeeetssooot",
            "gfdgfd",
            "gfdgfdfasdfdsfddfsfdfsdfdsfdsfsdfsdfsdfdsfsdfsdfsdfdsfdsfdsfdsfsd",
            "gfdgfd",
            "gfdgfd",
            "hola",
            "hola",
            "hola",
            "hola",
            "manolo",
            "manolo",
            "manolo",
            "manolo"});
            this.lstSearchResults.Location = new System.Drawing.Point(432, 111);
            this.lstSearchResults.MaximumSize = new System.Drawing.Size(160, 176);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(160, 176);
            this.lstSearchResults.TabIndex = 9;
            this.lstSearchResults.Visible = false;
            // 
            // paneAlert
            // 
            this.paneAlert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneAlert.Controls.Add(this.lblAlert);
            this.paneAlert.Controls.Add(this.lblAlertNum);
            this.paneAlert.Controls.Add(this.alertImage);
            this.paneAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneAlert.Location = new System.Drawing.Point(26, 376);
            this.paneAlert.Name = "paneAlert";
            this.paneAlert.Size = new System.Drawing.Size(321, 112);
            this.paneAlert.TabIndex = 10;
            this.paneAlert.Click += new System.EventHandler(this.openAlertWindow);
            // 
            // alertImage
            // 
            this.alertImage.Image = global::Business_under_control.Properties.Resources.alert;
            this.alertImage.Location = new System.Drawing.Point(20, 20);
            this.alertImage.Margin = new System.Windows.Forms.Padding(0);
            this.alertImage.Name = "alertImage";
            this.alertImage.Size = new System.Drawing.Size(79, 79);
            this.alertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alertImage.TabIndex = 1;
            this.alertImage.TabStop = false;
            this.alertImage.Click += new System.EventHandler(this.openAlertWindow);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(780, 217);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(134, 16);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "rest@danmark.com";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(797, 243);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(90, 16);
            this.lblTelephone.TabIndex = 12;
            this.lblTelephone.Text = "630 876 333";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebsite.Location = new System.Drawing.Point(797, 271);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(95, 16);
            this.lblWebsite.TabIndex = 13;
            this.lblWebsite.Text = "danmark.com";
            // 
            // lblEditFirm
            // 
            this.lblEditFirm.AutoSize = true;
            this.lblEditFirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditFirm.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFirm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEditFirm.Location = new System.Drawing.Point(883, 162);
            this.lblEditFirm.Name = "lblEditFirm";
            this.lblEditFirm.Size = new System.Drawing.Size(25, 12);
            this.lblEditFirm.TabIndex = 14;
            this.lblEditFirm.Text = "Edit";
            this.lblEditFirm.Click += new System.EventHandler(this.lblEditFirm_Click);
            this.lblEditFirm.MouseEnter += new System.EventHandler(this.lblEditFirm_MouseEnter);
            this.lblEditFirm.MouseLeave += new System.EventHandler(this.lblEditFirm_MouseLeave);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::Business_under_control.Properties.Resources.cloud_computing;
            this.pbRefresh.Location = new System.Drawing.Point(360, 376);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(37, 32);
            this.pbRefresh.TabIndex = 15;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            this.pbRefresh.MouseHover += new System.EventHandler(this.pbRefresh_MouseHover);
            // 
            // firmLogo
            // 
            this.firmLogo.Image = global::Business_under_control.Properties.Resources.logo;
            this.firmLogo.Location = new System.Drawing.Point(783, 34);
            this.firmLogo.Name = "firmLogo";
            this.firmLogo.Size = new System.Drawing.Size(125, 125);
            this.firmLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firmLogo.TabIndex = 4;
            this.firmLogo.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.lblEditFirm);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.paneAlert);
            this.Controls.Add(this.lstSearchResults);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flPaneOptions);
            this.Controls.Add(this.lblFirmName);
            this.Controls.Add(this.firmLogo);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnStatistics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(950, 550);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "MainScreen";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Business under control";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.flPaneOptions.ResumeLayout(false);
            this.paneAlert.ResumeLayout(false);
            this.paneAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.PictureBox alertImage;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.PictureBox firmLogo;
        private System.Windows.Forms.Label lblFirmName;
        private System.Windows.Forms.FlowLayoutPanel flPaneOptions;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.Label lblAlertNum;
        private System.Windows.Forms.Panel paneAlert;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblEditFirm;
        private System.Windows.Forms.PictureBox pbRefresh;
    }
}

