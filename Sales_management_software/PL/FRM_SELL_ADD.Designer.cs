namespace Sales_management_software.PL
{
    partial class FRM_SELL_ADD
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
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.ComboBox();
            this.edt_cus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edt_qt = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edt_sell = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_qt = new System.Windows.Forms.Label();
            this.txt_buy = new System.Windows.Forms.Label();
            this.txt_sell = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_title.ForeColor = System.Drawing.Color.Gray;
            this.lb_title.Location = new System.Drawing.Point(19, 21);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(168, 29);
            this.lb_title.TabIndex = 7;
            this.lb_title.Text = "product name";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = global::Sales_management_software.Properties.Resources.addfile_32x32;
            this.btn_add.Location = new System.Drawing.Point(1023, 615);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 61);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "ADD";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "customer";
            // 
            // edt_name
            // 
            this.edt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_name.FormattingEnabled = true;
            this.edt_name.Location = new System.Drawing.Point(227, 26);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(268, 24);
            this.edt_name.TabIndex = 16;
            this.edt_name.SelectedIndexChanged += new System.EventHandler(this.edt_name_SelectedIndexChanged);
            // 
            // edt_cus
            // 
            this.edt_cus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edt_cus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_cus.FormattingEnabled = true;
            this.edt_cus.Location = new System.Drawing.Point(227, 69);
            this.edt_cus.Name = "edt_cus";
            this.edt_cus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_cus.Size = new System.Drawing.Size(268, 24);
            this.edt_cus.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.edt_cus);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Controls.Add(this.edt_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 152);
            this.panel1.TabIndex = 17;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(510, 77);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(32, 16);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(510, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 16);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.edt_qt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.edt_sell);
            this.panel2.Location = new System.Drawing.Point(28, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 146);
            this.panel2.TabIndex = 18;
            // 
            // edt_qt
            // 
            this.edt_qt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_qt.EnterMoveNextControl = true;
            this.edt_qt.Location = new System.Drawing.Point(237, 79);
            this.edt_qt.Name = "edt_qt";
            this.edt_qt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.edt_qt.Properties.Appearance.Options.UseFont = true;
            this.edt_qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_qt.Properties.MaskSettings.Set("mask", "");
            this.edt_qt.Size = new System.Drawing.Size(385, 30);
            this.edt_qt.TabIndex = 12;
            
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(19, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "selling price";
            // 
            // edt_sell
            // 
            this.edt_sell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_sell.Location = new System.Drawing.Point(237, 22);
            this.edt_sell.Name = "edt_sell";
            this.edt_sell.Size = new System.Drawing.Size(385, 34);
            this.edt_sell.TabIndex = 11;
            this.edt_sell.Text = "0";
            this.edt_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_qt);
            this.panel3.Controls.Add(this.txt_buy);
            this.panel3.Controls.Add(this.txt_sell);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(737, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 384);
            this.panel3.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(107, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(200, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "Quantity is not enough";
            this.label10.Visible = false;
            // 
            // txt_qt
            // 
            this.txt_qt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_qt.AutoSize = true;
            this.txt_qt.BackColor = System.Drawing.Color.White;
            this.txt_qt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_qt.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_qt.Location = new System.Drawing.Point(147, 264);
            this.txt_qt.Name = "txt_qt";
            this.txt_qt.Size = new System.Drawing.Size(27, 29);
            this.txt_qt.TabIndex = 7;
            this.txt_qt.Text = "0";
            // 
            // txt_buy
            // 
            this.txt_buy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_buy.AutoSize = true;
            this.txt_buy.BackColor = System.Drawing.Color.White;
            this.txt_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_buy.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_buy.Location = new System.Drawing.Point(147, 177);
            this.txt_buy.Name = "txt_buy";
            this.txt_buy.Size = new System.Drawing.Size(27, 29);
            this.txt_buy.TabIndex = 7;
            this.txt_buy.Text = "0";
            // 
            // txt_sell
            // 
            this.txt_sell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sell.AutoSize = true;
            this.txt_sell.BackColor = System.Drawing.Color.White;
            this.txt_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_sell.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_sell.Location = new System.Drawing.Point(147, 89);
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(27, 29);
            this.txt_sell.TabIndex = 7;
            this.txt_sell.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(59, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Purchasing price";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(737, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 45);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Product details";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // FRM_SELL_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SELL_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FRM_PUR_ADD_Activated);
            this.Load += new System.EventHandler(this.FRM_PUR_ADD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_title;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox edt_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox edt_sell;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.ComboBox edt_cus;
        public DevExpress.XtraEditors.SpinEdit edt_qt;
        public System.Windows.Forms.Label txt_qt;
        public System.Windows.Forms.Label txt_buy;
        public System.Windows.Forms.Label txt_sell;
        public System.Windows.Forms.TextBox textBox1;
    }
}