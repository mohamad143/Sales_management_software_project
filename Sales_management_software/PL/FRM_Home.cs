using Sales_management_software.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_management_software.PL
{
    public partial class FRM_Home : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        public FRM_Home()
        {
            InitializeComponent();
            List<TB_CAT> list_cat = db.TB_CAT.ToList();
            lb_cat.Text = list_cat.Count.ToString();
            List<TB_CuS> list_cus = db.TB_CuS.ToList();
            lb_cus.Text = list_cus.Count.ToString();
            List<TB_Pur> list_pur = db.TB_Pur.ToList();
            lb_pur.Text = list_pur.Count.ToString();
            List<TB_Sell> list_sell = db.TB_Sell.ToList();
            lb_sales.Text = list_sell.Count.ToString();
            List<TB_Supp> list_sup = db.TB_Supp.ToList();
            lb_sup.Text = list_sup.Count.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            List<TB_CAT> list_cat = db.TB_CAT.ToList();
            lb_cat.Text = list_cat.Count.ToString();
            List<TB_CuS> list_cus = db.TB_CuS.ToList();
            lb_cus.Text = list_cus.Count.ToString();
            List<TB_Pur> list_pur = db.TB_Pur.ToList();
            lb_pur.Text = list_pur.Count.ToString();
            List<TB_Sell> list_sell = db.TB_Sell.ToList();
            lb_sales.Text = list_sell.Count.ToString();
            List<TB_Supp> list_sup = db.TB_Supp.ToList();
            lb_sup.Text = list_sup.Count.ToString();
        }

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "add";
            frm_add.Show();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            FRM_SELL_ADD frm_add = new FRM_SELL_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "add";
            frm_add.Show();
        }

        private void btn_add_pur_Click(object sender, EventArgs e)
        {
            FRM_PUR_ADD frm_add = new FRM_PUR_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "add";
            frm_add.Show();
        }

        private void btn_add_cus_Click(object sender, EventArgs e)
        {
             FRM_CUS_ADD frm_add = new FRM_CUS_ADD();
             frm_add.id = 0;
             frm_add.btn_add.Text = "add";
             frm_add.Show();
        }

        private void btn_add_Suppliers_Click(object sender, EventArgs e)
        {

            FRM_SUPP_ADD frm_add = new FRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "add";
            frm_add.Show();
        }
    }
}
