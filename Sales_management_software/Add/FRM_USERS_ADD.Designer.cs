namespace Sales_management_software.PL
{
    partial class FRM_USERS_ADD
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
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_roll = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_title.ForeColor = System.Drawing.Color.Gray;
            this.lb_title.Location = new System.Drawing.Point(86, 175);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(137, 29);
            this.lb_title.TabIndex = 7;
            this.lb_title.Text = "Name user";
            // 
            // edt_name
            // 
            this.edt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_name.Location = new System.Drawing.Point(229, 170);
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
            this.btn_add.Location = new System.Drawing.Point(229, 361);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(238, 61);
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
            this.label1.Location = new System.Drawing.Point(86, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "password";
            // 
            // edt_pass
            // 
            this.edt_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_pass.Location = new System.Drawing.Point(229, 213);
            this.edt_pass.Name = "edt_pass";
            this.edt_pass.Size = new System.Drawing.Size(385, 34);
            this.edt_pass.TabIndex = 11;
            this.edt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(86, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Roll";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(235, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add a user";
            // 
            // edt_roll
            // 
            this.edt_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_roll.FormattingEnabled = true;
            this.edt_roll.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.edt_roll.Location = new System.Drawing.Point(229, 257);
            this.edt_roll.Name = "edt_roll";
            this.edt_roll.Size = new System.Drawing.Size(385, 34);
            this.edt_roll.TabIndex = 14;
            // 
            // FRM_USERS_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 601);
            this.Controls.Add(this.edt_roll);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.lb_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_USERS_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_title;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox edt_roll;
    }
}