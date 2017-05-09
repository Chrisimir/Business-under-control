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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsScreen));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIncomeExpenses = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabProviders = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabIncomeExpenses.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabProviders.SuspendLayout();
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
            this.tabIncomeExpenses.Controls.Add(this.btnExit);
            this.tabIncomeExpenses.Location = new System.Drawing.Point(4, 22);
            this.tabIncomeExpenses.Name = "tabIncomeExpenses";
            this.tabIncomeExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncomeExpenses.Size = new System.Drawing.Size(926, 486);
            this.tabIncomeExpenses.TabIndex = 0;
            this.tabIncomeExpenses.Text = "Income/Expenses";
            this.tabIncomeExpenses.UseVisualStyleBackColor = true;
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
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.button1);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(926, 486);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
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
            // 
            // tabProviders
            // 
            this.tabProviders.Controls.Add(this.button2);
            this.tabProviders.Location = new System.Drawing.Point(4, 22);
            this.tabProviders.Name = "tabProviders";
            this.tabProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tabProviders.Size = new System.Drawing.Size(926, 486);
            this.tabProviders.TabIndex = 2;
            this.tabProviders.Text = "Providers";
            this.tabProviders.UseVisualStyleBackColor = true;
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
            this.tabControl1.ResumeLayout(false);
            this.tabIncomeExpenses.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProviders.ResumeLayout(false);
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
    }
}