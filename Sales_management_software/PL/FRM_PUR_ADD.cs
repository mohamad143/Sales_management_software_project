using Sales_management_software.EPL;
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
    public partial class FRM_PUR_ADD: Form
    {
        // init
        DB_SMPEntities1 db=new DB_SMPEntities1();
        TB_Pur tb_pur = new TB_Pur();   
        BL.Methods methods=new BL.Methods();    

        public int id;
        double buy, sell, qt, tbuy, tsell, trev;

        public FRM_PUR_ADD()
        {
            InitializeComponent();
        }
        // add or edit
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();

            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "category name required";
                dialog.Show();
            }
            else
            {
                // check add or edit
                if (id == 0)
                {
                    //ADD
                    tb_pur.Pur_Name = edt_name.Text;
                    tb_pur.Pur_Type= edt_type.Text;
                    tb_pur.Pur_Cat=edt_cat.Text;
                    tb_pur.Pur_Sup= edt_sup.Text;
                    tb_pur.Pur_Det= edt_det.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                    tb_pur.Pur_Qt= Convert.ToDouble(edt_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_pur.Pur_TRev=Convert.ToDouble(edt_trev.Text);
                    db.TB_Pur.Add(tb_pur);
                    toast.txt_caption.Text = "A new supp has been added";
                    db.SaveChanges();
                    toast.txt_caption.Text = "Purchase completed";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    
                    tb_pur.ID = id;
                    tb_pur.Pur_Name = edt_name.Text;
                    tb_pur.Pur_Type = edt_type.Text;
                    tb_pur.Pur_Cat = edt_cat.Text;
                    tb_pur.Pur_Sup = edt_sup.Text;
                    tb_pur.Pur_Det = edt_det.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);
                    db.Entry(tb_pur).State = System.Data.Entity.EntityState.Modified;
                    toast.txt_caption.Text = " Purchase has been modified";
                    db.SaveChanges();
                    toast.Show();
                    this.Close();
                }
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edt_sell_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void FRM_PUR_ADD_Load(object sender, EventArgs e)
        {

        }

        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
            edt_cat.DataSource = db.TB_CAT.Select(x => x.CAT_Name).ToList();
            edt_sup.DataSource = db.TB_Supp.Select(x => x.Supp_Name).ToList();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_CAT_ADD fRM_add = new PL.FRM_CAT_ADD();
            fRM_add.id = 0;
            fRM_add.btn_add.Text = "add";
            fRM_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_SUPP_ADD fRM_add = new PL.FRM_SUPP_ADD();
            fRM_add.id = 0;
            fRM_add.btn_add.Text = "add";
            fRM_add.Show();
        }
        private void pro_cal()
        {
            try
            {

                sell = Convert.ToDouble(edt_sell.Text);
                buy = Convert.ToDouble(edt_buy.Text);
                qt = Convert.ToDouble(edt_qt.Value);
                tsell = sell * qt;
                tbuy = buy * qt;
                trev = tsell - tbuy;
                edt_tsell.Text = tsell.ToString();
                edt_tbuy.Text = tbuy.ToString();
                edt_trev.Text = trev.ToString();
            }
            catch
            {
                
                tsell = sell * qt;
                tbuy = buy * qt;
                trev = tsell - tbuy;
                edt_tsell.Text = tsell.ToString();
                edt_tbuy.Text = tbuy.ToString();
                edt_trev.Text = trev.ToString();
            }
           
            
        }
    }
}
