namespace Business_under_control
{
    partial class AlertListWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertListWindow));
            this.lstAlerts = new System.Windows.Forms.ListBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblNoAlerts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAlerts
            // 
            this.lstAlerts.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAlerts.FormattingEnabled = true;
            this.lstAlerts.ItemHeight = 16;
            this.lstAlerts.Location = new System.Drawing.Point(2, 44);
            this.lstAlerts.Name = "lstAlerts";
            this.lstAlerts.Size = new System.Drawing.Size(381, 388);
            this.lstAlerts.TabIndex = 0;
            this.lstAlerts.Visible = false;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(155, 18);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(74, 23);
            this.lblAlert.TabIndex = 1;
            this.lblAlert.Text = "Alerts";
            // 
            // lblNoAlerts
            // 
            this.lblNoAlerts.AutoSize = true;
            this.lblNoAlerts.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAlerts.Location = new System.Drawing.Point(139, 193);
            this.lblNoAlerts.Name = "lblNoAlerts";
            this.lblNoAlerts.Size = new System.Drawing.Size(108, 25);
            this.lblNoAlerts.TabIndex = 2;
            this.lblNoAlerts.Text = "No alerts";
            // 
            // AlertListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 442);
            this.Controls.Add(this.lblNoAlerts);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lstAlerts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlertListWindow";
            this.Text = "Alerts";
            this.Load += new System.EventHandler(this.AlertListWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAlerts;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label lblNoAlerts;
    }
}