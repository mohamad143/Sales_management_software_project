namespace Sales_management_software.PL
{
    partial class FRM_SUPP_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SUPP_ADD));
            this.lb_title = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_title.ForeColor = System.Drawing.Color.Gray;
            this.lb_title.Location = new System.Drawing.Point(12, 59);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(147, 29);
            this.lb_title.TabIndex = 7;
            this.lb_title.Text = "Name Supp";
            // 
            // edt_name
            // 
            this.edt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_name.Location = new System.Drawing.Point(263, 59);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(385, 34);
            this.edt_name.TabIndex = 11;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = global::Sales_management_software.Properties.Resources.addfile_32x32;
            this.btn_add.Location = new System.Drawing.Point(642, 698);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 61);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "ADD";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(263, 215);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.pic_cover.Properties.Appearance.Options.UseBackColor = true;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(385, 343);
            this.pic_cover.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Num Phone";
            // 
            // edt_phone
            // 
            this.edt_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_phone.Location = new System.Drawing.Point(263, 99);
            this.edt_phone.Name = "edt_phone";
            this.edt_phone.Size = new System.Drawing.Size(385, 34);
            this.edt_phone.TabIndex = 11;
            this.edt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // edt_email
            // 
            this.edt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_email.Location = new System.Drawing.Point(263, 139);
            this.edt_email.Name = "edt_email";
            this.edt_email.Size = new System.Drawing.Size(385, 34);
            this.edt_email.TabIndex = 11;
            this.edt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(405, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Image";
            // 
            // FRM_SUPP_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 773);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.lb_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SUPP_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_title;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox edt_name;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edt_phone;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edt_email;
        private System.Windows.Forms.Label label3;
    }
}