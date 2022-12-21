namespace Sales_management_software.PL
{
    partial class FRM_Login
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
            this.edt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_title.ForeColor = System.Drawing.Color.Gray;
            this.lb_title.Location = new System.Drawing.Point(17, 175);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(137, 29);
            this.lb_title.TabIndex = 7;
            this.lb_title.Text = "Name user";
            // 
            // edt_name
            // 
            this.edt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_name.Location = new System.Drawing.Point(160, 175);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(385, 34);
            this.edt_name.TabIndex = 11;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(17, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "password";
            // 
            // edt_pass
            // 
            this.edt_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_pass.Location = new System.Drawing.Point(160, 215);
            this.edt_pass.Name = "edt_pass";
            this.edt_pass.Size = new System.Drawing.Size(385, 34);
            this.edt_pass.TabIndex = 11;
            this.edt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(218, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sign in";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Vivaldi", 20F);
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Location = new System.Drawing.Point(175, 333);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(238, 61);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "sign in";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 471);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edt_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.lb_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_title;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edt_pass;
        private System.Windows.Forms.Label label3;
    }
}