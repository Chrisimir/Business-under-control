namespace Business_under_control
{
    partial class StatisticsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsScreen));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIncomeExpenses = new System.Windows.Forms.TabPage();
            this.chrtIncomeOutcome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.lbAmountSold = new System.Windows.Forms.ListBox();
            this.lblSold = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabProviders = new System.Windows.Forms.TabPage();
            this.dgvProductsSupp = new System.Windows.Forms.DataGridView();
            this.lblProducts = new System.Windows.Forms.Label();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnSeeSupplier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabIncomeExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncomeOutcome)).BeginInit();
            this.tabProducts.SuspendLayout();
            this.tabProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIncomeExpenses);
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabProviders);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // tabIncomeExpenses
            // 
            this.tabIncomeExpenses.Controls.Add(this.chrtIncomeOutcome);
            this.tabIncomeExpenses.Controls.Add(this.btnExit);
            this.tabIncomeExpenses.Location = new System.Drawing.Point(4, 22);
            this.tabIncomeExpenses.Name = "tabIncomeExpenses";
            this.tabIncomeExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncomeExpenses.Size = new System.Drawing.Size(926, 486);
            this.tabIncomeExpenses.TabIndex = 0;
            this.tabIncomeExpenses.Text = "Income/Expenses";
            this.tabIncomeExpenses.UseVisualStyleBackColor = true;
            // 
            // chrtIncomeOutcome
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtIncomeOutcome.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtIncomeOutcome.Legends.Add(legend1);
            this.chrtIncomeOutcome.Location = new System.Drawing.Point(8, 6);
            this.chrtIncomeOutcome.Name = "chrtIncomeOutcome";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtIncomeOutcome.Series.Add(series1);
            this.chrtIncomeOutcome.Size = new System.Drawing.Size(724, 472);
            this.chrtIncomeOutcome.TabIndex = 3;
            this.chrtIncomeOutcome.Text = "Income Outcome";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = global::Business_under_control.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(839, 410);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.CloseWindow);
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.lbAmountSold);
            this.tabProducts.Controls.Add(this.lblSold);
            this.tabProducts.Controls.Add(this.button1);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(926, 486);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // lbAmountSold
            // 
            this.lbAmountSold.FormattingEnabled = true;
            this.lbAmountSold.Location = new System.Drawing.Point(314, 24);
            this.lbAmountSold.Name = "lbAmountSold";
            this.lbAmountSold.Size = new System.Drawing.Size(327, 420);
            this.lbAmountSold.TabIndex = 4;
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSold.Location = new System.Drawing.Point(108, 24);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(185, 18);
            this.lblSold.TabIndex = 3;
            this.lblSold.Text = "Amount sold (total):";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Business_under_control.Properties.Resources.exit;
            this.button1.Location = new System.Drawing.Point(839, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CloseWindow);
            // 
            // tabProviders
            // 
            this.tabProviders.Controls.Add(this.dgvProductsSupp);
            this.tabProviders.Controls.Add(this.lblProducts);
            this.tabProviders.Controls.Add(this.dgvSupplier);
            this.tabProviders.Controls.Add(this.btnSeeSupplier);
            this.tabProviders.Controls.Add(this.label1);
            this.tabProviders.Controls.Add(this.cbSupplier);
            this.tabProviders.Controls.Add(this.button2);
            this.tabProviders.Location = new System.Drawing.Point(4, 22);
            this.tabProviders.Name = "tabProviders";
            this.tabProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tabProviders.Size = new System.Drawing.Size(926, 486);
            this.tabProviders.TabIndex = 2;
            this.tabProviders.Text = "Providers";
            this.tabProviders.UseVisualStyleBackColor = true;
            // 
            // dgvProductsSupp
            // 
            this.dgvProductsSupp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsSupp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvProductsSupp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductsSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductsSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsSupp.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvProductsSupp.Location = new System.Drawing.Point(26, 274);
            this.dgvProductsSupp.Name = "dgvProductsSupp";
            this.dgvProductsSupp.Size = new System.Drawing.Size(800, 204);
            this.dgvProductsSupp.TabIndex = 8;
            this.dgvProductsSupp.Visible = false;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(23, 240);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(73, 18);
            this.lblProducts.TabIndex = 7;
            this.lblProducts.Text = "Products";
            this.lblProducts.Visible = false;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvSupplier.Location = new System.Drawing.Point(23, 134);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSupplier.Size = new System.Drawing.Size(800, 62);
            this.dgvSupplier.TabIndex = 6;
            this.dgvSupplier.Visible = false;
            // 
            // btnSeeSupplier
            // 
            this.btnSeeSupplier.Location = new System.Drawing.Point(212, 69);
            this.btnSeeSupplier.Name = "btnSeeSupplier";
            this.btnSeeSupplier.Size = new System.Drawing.Size(49, 23);
            this.btnSeeSupplier.TabIndex = 5;
            this.btnSeeSupplier.Text = "See";
            this.btnSeeSupplier.UseVisualStyleBackColor = true;
            this.btnSeeSupplier.Click += new System.EventHandler(this.btnSeeSupplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose supplier";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(23, 69);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(183, 21);
            this.cbSupplier.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Business_under_control.Properties.Resources.exit;
            this.button2.Location = new System.Drawing.Point(839, 410);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseWindow);
            // 
            // StatisticsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(950, 550);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "StatisticsScreen";
            this.Text = "StatisticsScreen";
            this.Load += new System.EventHandler(this.StatisticsScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabIncomeExpenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncomeOutcome)).EndInit();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.tabProviders.ResumeLayout(false);
            this.tabProviders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIncomeExpenses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabProviders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtIncomeOutcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Button btnSeeSupplier;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.DataGridView dgvProductsSupp;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.ListBox lbAmountSold;
    }
}