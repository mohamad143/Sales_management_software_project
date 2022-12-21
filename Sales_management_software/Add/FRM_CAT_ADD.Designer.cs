namespace Sales_management_software.PL
{
    partial class FRM_CAT_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CAT_ADD));
            this.lb_title = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_title.ForeColor = System.Drawing.Color.Gray;
            this.lb_title.Location = new System.Drawing.Point(265, 32);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(190, 29);
            this.lb_title.TabIndex = 7;
            this.lb_title.Text = "Name Category";
            // 
            // edt_name
            // 
            this.edt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_name.Location = new System.Drawing.Point(188, 84);
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
            this.btn_add.Location = new System.Drawing.Point(640, 375);
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
            this.pic_cover.Location = new System.Drawing.Point(188, 136);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(385, 293);
            this.pic_cover.TabIndex = 12;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(699, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_close.Size = new System.Drawing.Size(89, 50);
            this.btn_close.TabIndex = 6;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FRM_CAT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CAT_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.Label lb_title;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox edt_name;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
    }
}