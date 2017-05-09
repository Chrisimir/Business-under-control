namespace Business_under_control
{
    partial class OrdersScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersScreen));
            this.tabsOrder = new System.Windows.Forms.TabControl();
            this.tabCompareProviders = new System.Windows.Forms.TabPage();
            this.tabEstimates = new System.Windows.Forms.TabPage();
            this.tabListOrders = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabsOrder.SuspendLayout();
            this.tabCompareProviders.SuspendLayout();
            this.tabEstimates.SuspendLayout();
            this.tabListOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsOrder
            // 
            this.tabsOrder.Controls.Add(this.tabCompareProviders);
            this.tabsOrder.Controls.Add(this.tabEstimates);
            this.tabsOrder.Controls.Add(this.tabListOrders);
            this.tabsOrder.Location = new System.Drawing.Point(0, 0);
            this.tabsOrder.Name = "tabsOrder";
            this.tabsOrder.SelectedIndex = 0;
            this.tabsOrder.Size = new System.Drawing.Size(934, 512);
            this.tabsOrder.TabIndex = 0;
            // 
            // tabCompareProviders
            // 
            this.tabCompareProviders.Controls.Add(this.btnExit);
            this.tabCompareProviders.Location = new System.Drawing.Point(4, 22);
            this.tabCompareProviders.Name = "tabCompareProviders";
            this.tabCompareProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompareProviders.Size = new System.Drawing.Size(926, 486);
            this.tabCompareProviders.TabIndex = 0;
            this.tabCompareProviders.Text = "Compare Providers";
            this.tabCompareProviders.UseVisualStyleBackColor = true;
            // 
            // tabEstimates
            // 
            this.tabEstimates.Controls.Add(this.button1);
            this.tabEstimates.Location = new System.Drawing.Point(4, 22);
            this.tabEstimates.Name = "tabEstimates";
            this.tabEstimates.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstimates.Size = new System.Drawing.Size(926, 486);
            this.tabEstimates.TabIndex = 1;
            this.tabEstimates.Text = "Estimates";
            this.tabEstimates.UseVisualStyleBackColor = true;
            // 
            // tabListOrders
            // 
            this.tabListOrders.Controls.Add(this.button2);
            this.tabListOrders.Location = new System.Drawing.Point(4, 22);
            this.tabListOrders.Name = "tabListOrders";
            this.tabListOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabListOrders.Size = new System.Drawing.Size(926, 486);
            this.tabListOrders.TabIndex = 2;
            this.tabListOrders.Text = "List orders";
            this.tabListOrders.UseVisualStyleBackColor = true;
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
            // OrdersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.tabsOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(950, 550);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "OrdersScreen";
            this.Text = "Orders";
            this.tabsOrder.ResumeLayout(false);
            this.tabCompareProviders.ResumeLayout(false);
            this.tabEstimates.ResumeLayout(false);
            this.tabListOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsOrder;
        private System.Windows.Forms.TabPage tabCompareProviders;
        private System.Windows.Forms.TabPage tabEstimates;
        private System.Windows.Forms.TabPage tabListOrders;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}