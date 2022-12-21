namespace Sales_management_software.PL
{
    partial class FRM_Report
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
            this.components = new System.ComponentModel.Container();
            this.pn_cat = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sell = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Suppliers_report = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Customers_report = new DevExpress.XtraEditors.SimpleButton();
            this.btnn_Purchases_report = new DevExpress.XtraEditors.SimpleButton();
            this.tBCATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pn_cat.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.flowLayoutPanel1);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1030, 720);
            this.pn_cat.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_sell);
            this.flowLayoutPanel1.Controls.Add(this.btn_Suppliers_report);
            this.flowLayoutPanel1.Controls.Add(this.btn_Customers_report);
            this.flowLayoutPanel1.Controls.Add(this.btnn_Purchases_report);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1030, 720);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_sell
            // 
            this.btn_sell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sell.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.btn_sell.Appearance.Options.UseFont = true;
            this.btn_sell.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomLeft;
            this.btn_sell.Location = new System.Drawing.Point(35, 35);
            this.btn_sell.Margin = new System.Windows.Forms.Padding(20);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(300, 300);
            this.btn_sell.TabIndex = 14;
            this.btn_sell.Text = "sales report";
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_Suppliers_report
            // 
            this.btn_Suppliers_report.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Suppliers_report.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.btn_Suppliers_report.Appearance.Options.UseFont = true;
            this.btn_Suppliers_report.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomLeft;
            this.btn_Suppliers_report.Location = new System.Drawing.Point(375, 35);
            this.btn_Suppliers_report.Margin = new System.Windows.Forms.Padding(20);
            this.btn_Suppliers_report.Name = "btn_Suppliers_report";
            this.btn_Suppliers_report.Size = new System.Drawing.Size(300, 300);
            this.btn_Suppliers_report.TabIndex = 18;
            this.btn_Suppliers_report.Text = "Suppliers report";
            this.btn_Suppliers_report.Click += new System.EventHandler(this.btn_Suppliers_report_Click);
            // 
            // btn_Customers_report
            // 
            this.btn_Customers_report.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Customers_report.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.btn_Customers_report.Appearance.Options.UseFont = true;
            this.btn_Customers_report.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomLeft;
            this.btn_Customers_report.Location = new System.Drawing.Point(35, 375);
            this.btn_Customers_report.Margin = new System.Windows.Forms.Padding(20);
            this.btn_Customers_report.Name = "btn_Customers_report";
            this.btn_Customers_report.Size = new System.Drawing.Size(300, 300);
            this.btn_Customers_report.TabIndex = 16;
            this.btn_Customers_report.Text = "Customers report";
            this.btn_Customers_report.Click += new System.EventHandler(this.btn_Customers_report_Click);
            // 
            // btnn_Purchases_report
            // 
            this.btnn_Purchases_report.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnn_Purchases_report.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.btnn_Purchases_report.Appearance.Options.UseFont = true;
            this.btnn_Purchases_report.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomLeft;
            this.btnn_Purchases_report.Location = new System.Drawing.Point(375, 375);
            this.btnn_Purchases_report.Margin = new System.Windows.Forms.Padding(20);
            this.btnn_Purchases_report.Name = "btnn_Purchases_report";
            this.btnn_Purchases_report.Size = new System.Drawing.Size(300, 300);
            this.btnn_Purchases_report.TabIndex = 19;
            this.btnn_Purchases_report.Text = "Purchases report";
            this.btnn_Purchases_report.Click += new System.EventHandler(this.btnn_Purchases_report_Click);
            // 
            // tBCATBindingSource
            // 
            this.tBCATBindingSource.DataMember = "TB_CAT";
            // 
            // FRM_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Report";
            this.Text = "FRM_Cat";
            this.pn_cat.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pn_cat;

        private System.Windows.Forms.BindingSource tBCATBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public DevExpress.XtraEditors.SimpleButton btn_sell;
        public DevExpress.XtraEditors.SimpleButton btn_purchases_report;
        public DevExpress.XtraEditors.SimpleButton btn_Customers_report;
        public DevExpress.XtraEditors.SimpleButton btn_Suppliers_report;
        public DevExpress.XtraEditors.SimpleButton btnn_Purchases_report;
    }
}