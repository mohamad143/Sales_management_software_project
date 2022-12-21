namespace Sales_management_software
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_topbar = new System.Windows.Forms.Panel();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_max = new DevExpress.XtraEditors.SimpleButton();
            this.btn_min = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sup = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pur = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cus = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sales = new DevExpress.XtraEditors.SimpleButton();
            this.btn_rep = new DevExpress.XtraEditors.SimpleButton();
            this.btn_users = new DevExpress.XtraEditors.SimpleButton();
            this.pn_headernavbar = new System.Windows.Forms.Panel();
            this.pn_titlenav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_roll = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bnt_collapse = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pn_topbar.SuspendLayout();
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_headernavbar.SuspendLayout();
            this.pn_titlenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_topbar
            // 
            this.pn_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pn_topbar.Controls.Add(this.btn_login);
            this.pn_topbar.Controls.Add(this.lb_title);
            this.pn_topbar.Controls.Add(this.btn_max);
            this.pn_topbar.Controls.Add(this.btn_min);
            this.pn_topbar.Controls.Add(this.btn_close);
            this.pn_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topbar.Location = new System.Drawing.Point(250, 0);
            this.pn_topbar.Name = "pn_topbar";
            this.pn_topbar.Size = new System.Drawing.Size(1030, 56);
            this.pn_topbar.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_login.ImageOptions.Image = global::Sales_management_software.Properties.Resources.assigntome_32x32;
            this.btn_login.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_login.Location = new System.Drawing.Point(830, 0);
            this.btn_login.Name = "btn_login";
            this.btn_login.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_login.Size = new System.Drawing.Size(50, 56);
            this.btn_login.TabIndex = 3;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_title
            // 
            this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_title.ForeColor = System.Drawing.Color.Transparent;
            this.lb_title.Location = new System.Drawing.Point(444, 14);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(66, 27);
            this.lb_title.TabIndex = 6;
            this.lb_title.Text = "Main";
            // 
            // btn_max
            // 
            this.btn_max.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_max.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.ImageOptions.Image")));
            this.btn_max.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_max.Location = new System.Drawing.Point(880, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_max.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_max.Size = new System.Drawing.Size(50, 56);
            this.btn_max.TabIndex = 4;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.ImageOptions.Image")));
            this.btn_min.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_min.Location = new System.Drawing.Point(930, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_min.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_min.Size = new System.Drawing.Size(50, 56);
            this.btn_min.TabIndex = 3;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(980, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_close.Size = new System.Drawing.Size(50, 56);
            this.btn_close.TabIndex = 5;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Controls.Add(this.pn_headernavbar);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_navbar.Location = new System.Drawing.Point(0, 0);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(250, 720);
            this.pn_navbar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Controls.Add(this.btn_home);
            this.flowLayoutPanel1.Controls.Add(this.btn_cat);
            this.flowLayoutPanel1.Controls.Add(this.btn_sup);
            this.flowLayoutPanel1.Controls.Add(this.btn_pur);
            this.flowLayoutPanel1.Controls.Add(this.btn_cus);
            this.flowLayoutPanel1.Controls.Add(this.btn_sales);
            this.flowLayoutPanel1.Controls.Add(this.btn_rep);
            this.flowLayoutPanel1.Controls.Add(this.btn_users);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 545);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Appearance.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_home.Appearance.Options.UseFont = true;
            this.btn_home.Appearance.Options.UseForeColor = true;
            this.btn_home.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.ImageOptions.Image")));
            this.btn_home.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(3, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_home.Size = new System.Drawing.Size(197, 41);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.Appearance.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_cat.Appearance.Options.UseFont = true;
            this.btn_cat.Appearance.Options.UseForeColor = true;
            this.btn_cat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cat.ImageOptions.Image")));
            this.btn_cat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_cat.Location = new System.Drawing.Point(3, 50);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_cat.Size = new System.Drawing.Size(197, 41);
            this.btn_cat.TabIndex = 3;
            this.btn_cat.Text = "Categories";
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // btn_sup
            // 
            this.btn_sup.Appearance.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_sup.Appearance.Options.UseFont = true;
            this.btn_sup.Appearance.Options.UseForeColor = true;
            this.btn_sup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sup.ImageOptions.Image")));
            this.btn_sup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_sup.Location = new System.Drawing.Point(3, 97);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_sup.Size = new System.Drawing.Size(197, 41);
            this.btn_sup.TabIndex = 4;
            this.btn_sup.Text = "Suppliers";
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // btn_pur
            // 
            this.btn_pur.Appearance.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pur.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_pur.Appearance.Options.UseFont = true;
            this.btn_pur.Appearance.Options.UseForeColor = true;
            this.btn_pur.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_pur.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_pur.ImageOptions.SvgImage")));
            this.btn_pur.Location = new System.Drawing.Point(3, 144);
            this.btn_pur.Name = "btn_pur";
            this.btn_pur.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_pur.Size = new System.Drawing.Size(197, 41);
            this.btn_pur.TabIndex = 5;
            this.btn_pur.Text = "Purchases";
            this.btn_pur.Click += new System.EventHandler(this.btn_pur_Click);
            // 
            // btn_cus
            // 
            this.btn_cus.Appearance.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cus.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_cus.Appearance.Options.UseFont = true;
            this.btn_cus.Appearance.Options.UseForeColor = true;
            this.btn_cus.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_cus.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_cus.ImageOptions.SvgImage")));
            this.btn_cus.Location = new System.Drawing.Point(3, 191);
            this.btn_cus.Name = "btn_cus";
            this.btn_cus.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_cus.Size = new System.Drawing.Size(197, 41);
            this.btn_cus.TabIndex = 6;
            this.btn_cus.Text = "Customers";
            this.btn_cus.Click += new System.EventHandler(this.btn_cus_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Appearance.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_sales.Appearance.Options.UseFont = true;
            this.btn_sales.Appearance.Options.UseForeColor = true;
            this.btn_sales.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_sales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sales.ImageOptions.SvgImage")));
            this.btn_sales.Location = new System.Drawing.Point(3, 238);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_sales.Size = new System.Drawing.Size(197, 41);
            this.btn_sales.TabIndex = 7;
            this.btn_sales.Text = "Sales";
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_rep
            // 
            this.btn_rep.Appearance.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_rep.Appearance.Options.UseFont = true;
            this.btn_rep.Appearance.Options.UseForeColor = true;
            this.btn_rep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_rep.ImageOptions.Image")));
            this.btn_rep.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_rep.Location = new System.Drawing.Point(3, 285);
            this.btn_rep.Name = "btn_rep";
            this.btn_rep.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_rep.Size = new System.Drawing.Size(197, 41);
            this.btn_rep.TabIndex = 8;
            this.btn_rep.Text = "Reports";
            this.btn_rep.Click += new System.EventHandler(this.btn_rep_Click);
            // 
            // btn_users
            // 
            this.btn_users.Appearance.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_users.Appearance.Options.UseFont = true;
            this.btn_users.Appearance.Options.UseForeColor = true;
            this.btn_users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_users.ImageOptions.Image")));
            this.btn_users.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_users.Location = new System.Drawing.Point(3, 332);
            this.btn_users.Name = "btn_users";
            this.btn_users.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_users.Size = new System.Drawing.Size(197, 41);
            this.btn_users.TabIndex = 9;
            this.btn_users.Text = "Users";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // pn_headernavbar
            // 
            this.pn_headernavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pn_headernavbar.Controls.Add(this.pn_titlenav);
            this.pn_headernavbar.Controls.Add(this.flowLayoutPanel2);
            this.pn_headernavbar.Controls.Add(this.flowLayoutPanel3);
            this.pn_headernavbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pn_headernavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_headernavbar.Location = new System.Drawing.Point(0, 0);
            this.pn_headernavbar.Name = "pn_headernavbar";
            this.pn_headernavbar.Size = new System.Drawing.Size(250, 175);
            this.pn_headernavbar.TabIndex = 0;
            // 
            // pn_titlenav
            // 
            this.pn_titlenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pn_titlenav.Controls.Add(this.pictureBox1);
            this.pn_titlenav.Controls.Add(this.lb_UserName);
            this.pn_titlenav.Controls.Add(this.lb_roll);
            this.pn_titlenav.Location = new System.Drawing.Point(47, 3);
            this.pn_titlenav.Name = "pn_titlenav";
            this.pn_titlenav.Size = new System.Drawing.Size(200, 166);
            this.pn_titlenav.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_UserName
            // 
            this.lb_UserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.ForeColor = System.Drawing.Color.Red;
            this.lb_UserName.Location = new System.Drawing.Point(64, 107);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(75, 27);
            this.lb_UserName.TabIndex = 6;
            this.lb_UserName.Text = "Bdran";
            // 
            // lb_roll
            // 
            this.lb_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_roll.AutoSize = true;
            this.lb_roll.BackColor = System.Drawing.Color.Yellow;
            this.lb_roll.ForeColor = System.Drawing.Color.Blue;
            this.lb_roll.Location = new System.Drawing.Point(64, 134);
            this.lb_roll.Name = "lb_roll";
            this.lb_roll.Size = new System.Drawing.Size(81, 27);
            this.lb_roll.TabIndex = 6;
            this.lb_roll.Text = "Admin";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel2.Controls.Add(this.bnt_collapse);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(44, 175);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // bnt_collapse
            // 
            this.bnt_collapse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_collapse.ImageOptions.Image")));
            this.bnt_collapse.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bnt_collapse.Location = new System.Drawing.Point(3, 3);
            this.bnt_collapse.Name = "bnt_collapse";
            this.bnt_collapse.Size = new System.Drawing.Size(39, 29);
            this.bnt_collapse.TabIndex = 2;
            this.bnt_collapse.Click += new System.EventHandler(this.bnt_collapse_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(454, 111);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // pn_cont
            // 
            this.pn_cont.BackColor = System.Drawing.Color.White;
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(250, 56);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(1030, 664);
            this.pn_cont.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_topbar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.pn_topbar);
            this.Controls.Add(this.pn_navbar);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.Text = "SMP";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pn_topbar.ResumeLayout(false);
            this.pn_topbar.PerformLayout();
            this.pn_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_headernavbar.ResumeLayout(false);
            this.pn_titlenav.ResumeLayout(false);
            this.pn_titlenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topbar;
        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_cont;
        private System.Windows.Forms.Label lb_title;
        private DevExpress.XtraEditors.SimpleButton btn_min;
        private DevExpress.XtraEditors.SimpleButton btn_max;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.Panel pn_headernavbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton bnt_collapse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pn_titlenav;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Label lb_roll;
        public System.Windows.Forms.Label lb_UserName;
        public DevExpress.XtraEditors.SimpleButton btn_home;
        public DevExpress.XtraEditors.SimpleButton btn_cat;
        public DevExpress.XtraEditors.SimpleButton btn_sup;
        public DevExpress.XtraEditors.SimpleButton btn_pur;
        public DevExpress.XtraEditors.SimpleButton btn_cus;
        public DevExpress.XtraEditors.SimpleButton btn_sales;
        public DevExpress.XtraEditors.SimpleButton btn_rep;
        public DevExpress.XtraEditors.SimpleButton btn_users;
    }
}

