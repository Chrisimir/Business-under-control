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
            this.btnExitCompare = new System.Windows.Forms.Button();
            this.tabEstimates = new System.Windows.Forms.TabPage();
            this.btnExitOrdersEstimates = new System.Windows.Forms.Button();
            this.tabListOrders = new System.Windows.Forms.TabPage();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNewOrder = new System.Windows.Forms.Panel();
            this.btnProductRemove = new System.Windows.Forms.Button();
            this.lstNewOrder = new System.Windows.Forms.ListBox();
            this.btnNewOrderDatasheet = new System.Windows.Forms.Button();
            this.btnNewOrderTextFile = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblNewOrders = new System.Windows.Forms.Label();
            this.cbNewOrders = new System.Windows.Forms.ComboBox();
            this.btnOldOrderDatasheet = new System.Windows.Forms.Button();
            this.btnOldOrderText = new System.Windows.Forms.Button();
            this.lblOldOrders = new System.Windows.Forms.Label();
            this.cbOldOrders = new System.Windows.Forms.ComboBox();
            this.btnExitOrders = new System.Windows.Forms.Button();
            this.tabsOrder.SuspendLayout();
            this.tabCompareProviders.SuspendLayout();
            this.tabEstimates.SuspendLayout();
            this.tabListOrders.SuspendLayout();
            this.panelNewOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsOrder
            // 
            this.tabsOrder.Controls.Add(this.tabCompareProviders);
            this.tabsOrder.Controls.Add(this.tabEstimates);
            this.tabsOrder.Controls.Add(this.tabListOrders);
            this.tabsOrder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsOrder.Location = new System.Drawing.Point(0, 0);
            this.tabsOrder.Name = "tabsOrder";
            this.tabsOrder.SelectedIndex = 0;
            this.tabsOrder.Size = new System.Drawing.Size(934, 512);
            this.tabsOrder.TabIndex = 0;
            // 
            // tabCompareProviders
            // 
            this.tabCompareProviders.Controls.Add(this.btnExitCompare);
            this.tabCompareProviders.Location = new System.Drawing.Point(4, 25);
            this.tabCompareProviders.Name = "tabCompareProviders";
            this.tabCompareProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompareProviders.Size = new System.Drawing.Size(926, 483);
            this.tabCompareProviders.TabIndex = 0;
            this.tabCompareProviders.Text = "Compare Providers";
            this.tabCompareProviders.UseVisualStyleBackColor = true;
            // 
            // btnExitCompare
            // 
            this.btnExitCompare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitCompare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitCompare.Image = global::Business_under_control.Properties.Resources.exit;
            this.btnExitCompare.Location = new System.Drawing.Point(839, 410);
            this.btnExitCompare.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitCompare.Name = "btnExitCompare";
            this.btnExitCompare.Size = new System.Drawing.Size(80, 70);
            this.btnExitCompare.TabIndex = 2;
            this.btnExitCompare.Text = "Exit";
            this.btnExitCompare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExitCompare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExitCompare.UseVisualStyleBackColor = true;
            this.btnExitCompare.Click += new System.EventHandler(this.btnExitCompare_Click);
            // 
            // tabEstimates
            // 
            this.tabEstimates.Controls.Add(this.btnExitOrdersEstimates);
            this.tabEstimates.Location = new System.Drawing.Point(4, 25);
            this.tabEstimates.Name = "tabEstimates";
            this.tabEstimates.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstimates.Size = new System.Drawing.Size(926, 483);
            this.tabEstimates.TabIndex = 1;
            this.tabEstimates.Text = "Estimates";
            this.tabEstimates.UseVisualStyleBackColor = true;
            // 
            // btnExitOrdersEstimates
            // 
            this.btnExitOrdersEstimates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitOrdersEstimates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitOrdersEstimates.Image = global::Business_under_control.Properties.Resources.exit;
            this.btnExitOrdersEstimates.Location = new System.Drawing.Point(839, 410);
            this.btnExitOrdersEstimates.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitOrdersEstimates.Name = "btnExitOrdersEstimates";
            this.btnExitOrdersEstimates.Size = new System.Drawing.Size(80, 70);
            this.btnExitOrdersEstimates.TabIndex = 2;
            this.btnExitOrdersEstimates.Text = "Exit";
            this.btnExitOrdersEstimates.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExitOrdersEstimates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExitOrdersEstimates.UseVisualStyleBackColor = true;
            this.btnExitOrdersEstimates.Click += new System.EventHandler(this.btnExitOrdersEstimates_Click);
            // 
            // tabListOrders
            // 
            this.tabListOrders.Controls.Add(this.tbQuantity);
            this.tabListOrders.Controls.Add(this.label2);
            this.tabListOrders.Controls.Add(this.label1);
            this.tabListOrders.Controls.Add(this.panelNewOrder);
            this.tabListOrders.Controls.Add(this.btnAddProduct);
            this.tabListOrders.Controls.Add(this.lblNewOrders);
            this.tabListOrders.Controls.Add(this.cbNewOrders);
            this.tabListOrders.Controls.Add(this.btnOldOrderDatasheet);
            this.tabListOrders.Controls.Add(this.btnOldOrderText);
            this.tabListOrders.Controls.Add(this.lblOldOrders);
            this.tabListOrders.Controls.Add(this.cbOldOrders);
            this.tabListOrders.Controls.Add(this.btnExitOrders);
            this.tabListOrders.Location = new System.Drawing.Point(4, 25);
            this.tabListOrders.Name = "tabListOrders";
            this.tabListOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabListOrders.Size = new System.Drawing.Size(926, 483);
            this.tabListOrders.TabIndex = 2;
            this.tabListOrders.Text = "List orders";
            this.tabListOrders.UseVisualStyleBackColor = true;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(768, 290);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(53, 23);
            this.tbQuantity.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(750, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product:";
            // 
            // panelNewOrder
            // 
            this.panelNewOrder.Controls.Add(this.btnProductRemove);
            this.panelNewOrder.Controls.Add(this.lstNewOrder);
            this.panelNewOrder.Controls.Add(this.btnNewOrderDatasheet);
            this.panelNewOrder.Controls.Add(this.btnNewOrderTextFile);
            this.panelNewOrder.Location = new System.Drawing.Point(3, 3);
            this.panelNewOrder.Name = "panelNewOrder";
            this.panelNewOrder.Size = new System.Drawing.Size(466, 480);
            this.panelNewOrder.TabIndex = 11;
            // 
            // btnProductRemove
            // 
            this.btnProductRemove.Location = new System.Drawing.Point(389, 429);
            this.btnProductRemove.Name = "btnProductRemove";
            this.btnProductRemove.Size = new System.Drawing.Size(74, 23);
            this.btnProductRemove.TabIndex = 10;
            this.btnProductRemove.Text = "Remove";
            this.btnProductRemove.UseVisualStyleBackColor = true;
            // 
            // lstNewOrder
            // 
            this.lstNewOrder.FormattingEnabled = true;
            this.lstNewOrder.ItemHeight = 16;
            this.lstNewOrder.Location = new System.Drawing.Point(5, 3);
            this.lstNewOrder.Name = "lstNewOrder";
            this.lstNewOrder.Size = new System.Drawing.Size(458, 420);
            this.lstNewOrder.TabIndex = 9;
            // 
            // btnNewOrderDatasheet
            // 
            this.btnNewOrderDatasheet.Location = new System.Drawing.Point(5, 453);
            this.btnNewOrderDatasheet.Name = "btnNewOrderDatasheet";
            this.btnNewOrderDatasheet.Size = new System.Drawing.Size(158, 23);
            this.btnNewOrderDatasheet.TabIndex = 3;
            this.btnNewOrderDatasheet.Text = "Generate datasheet";
            this.btnNewOrderDatasheet.UseVisualStyleBackColor = true;
            this.btnNewOrderDatasheet.Click += new System.EventHandler(this.btnNewOrderDatasheet_Click);
            // 
            // btnNewOrderTextFile
            // 
            this.btnNewOrderTextFile.Location = new System.Drawing.Point(5, 424);
            this.btnNewOrderTextFile.Name = "btnNewOrderTextFile";
            this.btnNewOrderTextFile.Size = new System.Drawing.Size(158, 23);
            this.btnNewOrderTextFile.TabIndex = 8;
            this.btnNewOrderTextFile.Text = "Generate text file";
            this.btnNewOrderTextFile.UseVisualStyleBackColor = true;
            this.btnNewOrderTextFile.Click += new System.EventHandler(this.btnNewOrderTextFile_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(827, 290);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(72, 23);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblNewOrders
            // 
            this.lblNewOrders.AutoSize = true;
            this.lblNewOrders.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrders.Location = new System.Drawing.Point(506, 221);
            this.lblNewOrders.Name = "lblNewOrders";
            this.lblNewOrders.Size = new System.Drawing.Size(102, 18);
            this.lblNewOrders.TabIndex = 10;
            this.lblNewOrders.Text = "New order";
            // 
            // cbNewOrders
            // 
            this.cbNewOrders.FormattingEnabled = true;
            this.cbNewOrders.Items.AddRange(new object[] {
            "Fries",
            "Chips",
            "Potatoes",
            "Crisps",
            "Lays",
            "Cheetos",
            "Pringles"});
            this.cbNewOrders.Location = new System.Drawing.Point(509, 290);
            this.cbNewOrders.Name = "cbNewOrders";
            this.cbNewOrders.Size = new System.Drawing.Size(238, 24);
            this.cbNewOrders.TabIndex = 9;
            // 
            // btnOldOrderDatasheet
            // 
            this.btnOldOrderDatasheet.Location = new System.Drawing.Point(753, 90);
            this.btnOldOrderDatasheet.Name = "btnOldOrderDatasheet";
            this.btnOldOrderDatasheet.Size = new System.Drawing.Size(158, 23);
            this.btnOldOrderDatasheet.TabIndex = 4;
            this.btnOldOrderDatasheet.Text = "Generate datasheet";
            this.btnOldOrderDatasheet.UseVisualStyleBackColor = true;
            // 
            // btnOldOrderText
            // 
            this.btnOldOrderText.Location = new System.Drawing.Point(753, 119);
            this.btnOldOrderText.Name = "btnOldOrderText";
            this.btnOldOrderText.Size = new System.Drawing.Size(158, 23);
            this.btnOldOrderText.TabIndex = 6;
            this.btnOldOrderText.Text = "Generate text file";
            this.btnOldOrderText.UseVisualStyleBackColor = true;
            // 
            // lblOldOrders
            // 
            this.lblOldOrders.AutoSize = true;
            this.lblOldOrders.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldOrders.Location = new System.Drawing.Point(506, 41);
            this.lblOldOrders.Name = "lblOldOrders";
            this.lblOldOrders.Size = new System.Drawing.Size(100, 18);
            this.lblOldOrders.TabIndex = 5;
            this.lblOldOrders.Text = "Old orders";
            // 
            // cbOldOrders
            // 
            this.cbOldOrders.FormattingEnabled = true;
            this.cbOldOrders.Location = new System.Drawing.Point(509, 106);
            this.cbOldOrders.Name = "cbOldOrders";
            this.cbOldOrders.Size = new System.Drawing.Size(238, 24);
            this.cbOldOrders.TabIndex = 4;
            // 
            // btnExitOrders
            // 
            this.btnExitOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitOrders.Image = global::Business_under_control.Properties.Resources.exit;
            this.btnExitOrders.Location = new System.Drawing.Point(839, 410);
            this.btnExitOrders.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitOrders.Name = "btnExitOrders";
            this.btnExitOrders.Size = new System.Drawing.Size(80, 70);
            this.btnExitOrders.TabIndex = 2;
            this.btnExitOrders.Text = "Exit";
            this.btnExitOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExitOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExitOrders.UseVisualStyleBackColor = true;
            this.btnExitOrders.Click += new System.EventHandler(this.btnExitOrders_Click);
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
            this.tabListOrders.PerformLayout();
            this.panelNewOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsOrder;
        private System.Windows.Forms.TabPage tabCompareProviders;
        private System.Windows.Forms.TabPage tabEstimates;
        private System.Windows.Forms.TabPage tabListOrders;
        private System.Windows.Forms.Button btnExitCompare;
        private System.Windows.Forms.Button btnExitOrdersEstimates;
        private System.Windows.Forms.Button btnExitOrders;
        private System.Windows.Forms.Button btnNewOrderDatasheet;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblNewOrders;
        private System.Windows.Forms.ComboBox cbNewOrders;
        private System.Windows.Forms.Button btnOldOrderDatasheet;
        private System.Windows.Forms.Button btnNewOrderTextFile;
        private System.Windows.Forms.Button btnOldOrderText;
        private System.Windows.Forms.Label lblOldOrders;
        private System.Windows.Forms.ComboBox cbOldOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.Button btnProductRemove;
        private System.Windows.Forms.ListBox lstNewOrder;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}