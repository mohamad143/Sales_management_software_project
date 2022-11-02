using DevExpress.Utils.Extensions;
using Sales_management_software.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_management_software
{
    public partial class Main : Form
    {
        // Init Form
        PL.FRM_Home frm_home= new PL.FRM_Home();
        PL.FRM_Cat frm_cat= new PL.FRM_Cat();
        PL.FRM_SUPP frm_supp= new PL.FRM_SUPP();
        PL.FRM_PUR frm_pur= new PL.FRM_PUR();
        PL.FRM_CUS frm_cus= new PL.FRM_CUS();
        PL.FRM_SELL frm_sell= new PL.FRM_SELL();
        DB_SMPEntities1 db = new DB_SMPEntities1();
        public Main()
        {
            InitializeComponent();
        }
        // close app
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
        // min app
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    
        }
        // max app
        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState=FormWindowState.Maximized;
            }
            else
            {
                WindowState=FormWindowState.Normal;
            }

        }
        // collapse
        private void bnt_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width== 250)
            {
                pn_navbar.Width = 50;
                pn_titlenav.Visible = false;
                pn_headernavbar.Height = 150;
            }
            else
            {
                pn_navbar.Width = 250;
                pn_titlenav.Visible = true;
                pn_headernavbar.Height = 175;
            }

        }
        // load home page
        private void btn_home_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
        }
        // load cat 
        private void btn_cat_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cat.pn_cat);
            db = new DB_SMPEntities1();
            lb_title.Text = "categories";
        }
        // load supp
        
        private void btn_sup_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_supp.pn_cat);
            db = new DB_SMPEntities1();
            lb_title.Text = "Suppliers";
        }
        //laod purchases

        private void btn_pur_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_pur.pn_cat);
            db = new DB_SMPEntities1();
            lb_title.Text = "Purchases";
        }
        // load customers
        private void btn_cus_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cus.pn_cat);
            db = new DB_SMPEntities1();
            lb_title.Text = "Customers";
        }
        // load sales
        private void btn_sales_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_sell.pn_cat);
            db = new DB_SMPEntities1();
            lb_title.Text = "SALES";
        }

        private void btn_rep_Click(object sender, EventArgs e)
        {

        }

        private void btn_users_Click(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }
    }
}

