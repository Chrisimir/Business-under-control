namespace Business_under_control
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.tabsOrder = new System.Windows.Forms.TabControl();
            this.tabCompareProviders = new System.Windows.Forms.TabPage();
            this.gbByProduct = new System.Windows.Forms.GroupBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.btnCompareProducts = new System.Windows.Forms.Button();
            this.gbCompProviders = new System.Windows.Forms.GroupBox();
            this.cbProvider1 = new System.Windows.Forms.ComboBox();
            this.cbProvider2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExitCompare = new System.Windows.Forms.Button();
            this.tabEstimates = new System.Windows.Forms.TabPage();
            this.btnExitOrdersEstimates = new System.Windows.Forms.Button();
            this.tabListOrders = new System.Windows.Forms.TabPage();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNewOrder = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnProductRemove = new System.Windows.Forms.Button();
            this.lstNewOrder = new System.Windows.Forms.ListBox();
            this.btnSendToDatasheet = new System.Windows.Forms.Button();
            this.btnSendToTextFile = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblNewOrders = new System.Windows.Forms.Label();
            this.cbNewOrders = new System.Windows.Forms.ComboBox();
            this.btnOldOrderDatasheet = new System.Windows.Forms.Button();
            this.lblOldOrders = new System.Windows.Forms.Label();
            this.cbOldOrders = new System.Windows.Forms.ComboBox();
            this.btnExitOrders = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabsOrder.SuspendLayout();
            this.tabCompareProviders.SuspendLayout();
            this.gbByProduct.SuspendLayout();
            this.gbCompProviders.SuspendLayout();
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
            this.tabsOrder.SelectedIndexChanged += new System.EventHandler(this.tabsOrder_SelectedIndexChanged);
            // 
            // tabCompareProviders
            // 
            this.tabCompareProviders.Controls.Add(this.listView1);
            this.tabCompareProviders.Controls.Add(this.gbByProduct);
            this.tabCompareProviders.Controls.Add(this.gbCompProviders);
            this.tabCompareProviders.Controls.Add(this.btnExitCompare);
            this.tabCompareProviders.Location = new System.Drawing.Point(4, 25);
            this.tabCompareProviders.Name = "tabCompareProviders";
            this.tabCompareProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompareProviders.Size = new System.Drawing.Size(926, 483);
            this.tabCompareProviders.TabIndex = 0;
            this.tabCompareProviders.Text = "Compare Providers";
            this.tabCompareProviders.UseVisualStyleBackColor = true;
            // 
            // gbByProduct
            // 
            this.gbByProduct.Controls.Add(this.lblProduct);
            this.gbByProduct.Controls.Add(this.cbProducts);
            this.gbByProduct.Controls.Add(this.btnCompareProducts);
            this.gbByProduct.Location = new System.Drawing.Point(8, 246);
            this.gbByProduct.Name = "gbByProduct";
            this.gbByProduct.Size = new System.Drawing.Size(326, 182);
            this.gbByProduct.TabIndex = 11;
            this.gbByProduct.TabStop = false;
            this.gbByProduct.Text = "Compare suppliers by product";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(33, 44);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(59, 16);
            this.lblProduct.TabIndex = 8;
            this.lblProduct.Text = "Product";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(36, 63);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(228, 24);
            this.cbProducts.TabIndex = 8;
            // 
            // btnCompareProducts
            // 
            this.btnCompareProducts.Location = new System.Drawing.Point(110, 114);
            this.btnCompareProducts.Name = "btnCompareProducts";
            this.btnCompareProducts.Size = new System.Drawing.Size(75, 23);
            this.btnCompareProducts.TabIndex = 9;
            this.btnCompareProducts.Text = "Compare";
            this.btnCompareProducts.UseVisualStyleBackColor = true;
            this.btnCompareProducts.Click += new System.EventHandler(this.btnCompareProducts_Click);
            // 
            // gbCompProviders
            // 
            this.gbCompProviders.Controls.Add(this.cbProvider1);
            this.gbCompProviders.Controls.Add(this.cbProvider2);
            this.gbCompProviders.Controls.Add(this.label3);
            this.gbCompProviders.Controls.Add(this.btnCompare);
            this.gbCompProviders.Controls.Add(this.label4);
            this.gbCompProviders.Location = new System.Drawing.Point(8, 16);
            this.gbCompProviders.Name = "gbCompProviders";
            this.gbCompProviders.Size = new System.Drawing.Size(326, 200);
            this.gbCompProviders.TabIndex = 10;
            this.gbCompProviders.TabStop = false;
            this.gbCompProviders.Text = "Compare providers";
            // 
            // cbProvider1
            // 
            this.cbProvider1.FormattingEnabled = true;
            this.cbProvider1.Location = new System.Drawing.Point(48, 41);
            this.cbProvider1.Name = "cbProvider1";
            this.cbProvider1.Size = new System.Drawing.Size(228, 24);
            this.cbProvider1.TabIndex = 3;
            // 
            // cbProvider2
            // 
            this.cbProvider2.FormattingEnabled = true;
            this.cbProvider2.Location = new System.Drawing.Point(48, 111);
            this.cbProvider2.Name = "cbProvider2";
            this.cbProvider2.Size = new System.Drawing.Size(228, 24);
            this.cbProvider2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Provider 1";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(122, 162);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Provider 2";
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
            this.btnExitCompare.Click += new System.EventHandler(this.CloseWindow);
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
            this.btnExitOrdersEstimates.Click += new System.EventHandler(this.CloseWindow);
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
            this.panelNewOrder.Controls.Add(this.btnClearAll);
            this.panelNewOrder.Controls.Add(this.btnProductRemove);
            this.panelNewOrder.Controls.Add(this.lstNewOrder);
            this.panelNewOrder.Controls.Add(this.btnSendToDatasheet);
            this.panelNewOrder.Controls.Add(this.btnSendToTextFile);
            this.panelNewOrder.Location = new System.Drawing.Point(3, 3);
            this.panelNewOrder.Name = "panelNewOrder";
            this.panelNewOrder.Size = new System.Drawing.Size(466, 480);
            this.panelNewOrder.TabIndex = 11;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Enabled = false;
            this.btnClearAll.Location = new System.Drawing.Point(389, 454);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(74, 23);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnProductRemove
            // 
            this.btnProductRemove.Enabled = false;
            this.btnProductRemove.Location = new System.Drawing.Point(389, 425);
            this.btnProductRemove.Name = "btnProductRemove";
            this.btnProductRemove.Size = new System.Drawing.Size(74, 23);
            this.btnProductRemove.TabIndex = 10;
            this.btnProductRemove.Text = "Remove";
            this.btnProductRemove.UseVisualStyleBackColor = true;
            this.btnProductRemove.Click += new System.EventHandler(this.btnProductRemove_Click);
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
            // btnSendToDatasheet
            // 
            this.btnSendToDatasheet.Location = new System.Drawing.Point(5, 453);
            this.btnSendToDatasheet.Name = "btnSendToDatasheet";
            this.btnSendToDatasheet.Size = new System.Drawing.Size(158, 23);
            this.btnSendToDatasheet.TabIndex = 3;
            this.btnSendToDatasheet.Text = "Generate datasheet";
            this.btnSendToDatasheet.UseVisualStyleBackColor = true;
            this.btnSendToDatasheet.Click += new System.EventHandler(this.btnNewOrderDatasheet_Click);
            // 
            // btnSendToTextFile
            // 
            this.btnSendToTextFile.Location = new System.Drawing.Point(5, 424);
            this.btnSendToTextFile.Name = "btnSendToTextFile";
            this.btnSendToTextFile.Size = new System.Drawing.Size(158, 23);
            this.btnSendToTextFile.TabIndex = 8;
            this.btnSendToTextFile.Text = "Generate text file";
            this.btnSendToTextFile.UseVisualStyleBackColor = true;
            this.btnSendToTextFile.Click += new System.EventHandler(this.btnNewOrderTextFile_Click);
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
            this.btnOldOrderDatasheet.Location = new System.Drawing.Point(753, 106);
            this.btnOldOrderDatasheet.Name = "btnOldOrderDatasheet";
            this.btnOldOrderDatasheet.Size = new System.Drawing.Size(68, 24);
            this.btnOldOrderDatasheet.TabIndex = 4;
            this.btnOldOrderDatasheet.Text = "See";
            this.btnOldOrderDatasheet.UseVisualStyleBackColor = true;
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
            this.btnExitOrders.Click += new System.EventHandler(this.CloseWindow);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(423, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(495, 391);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.Load += new System.EventHandler(this.OrdersScreen_Load);
            this.tabsOrder.ResumeLayout(false);
            this.tabCompareProviders.ResumeLayout(false);
            this.gbByProduct.ResumeLayout(false);
            this.gbByProduct.PerformLayout();
            this.gbCompProviders.ResumeLayout(false);
            this.gbCompProviders.PerformLayout();
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
        private System.Windows.Forms.Button btnSendToDatasheet;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblNewOrders;
        private System.Windows.Forms.ComboBox cbNewOrders;
        private System.Windows.Forms.Button btnOldOrderDatasheet;
        private System.Windows.Forms.Button btnSendToTextFile;
        private System.Windows.Forms.Label lblOldOrders;
        private System.Windows.Forms.ComboBox cbOldOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.Button btnProductRemove;
        private System.Windows.Forms.ListBox lstNewOrder;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProvider2;
        private System.Windows.Forms.ComboBox cbProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbByProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Button btnCompareProducts;
        private System.Windows.Forms.GroupBox gbCompProviders;
        private System.Windows.Forms.ListView listView1;
    }
}