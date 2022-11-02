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
    public partial class FRM_SELL_ADD: Form
    {
        // init
        DB_SMPEntities1 db=new DB_SMPEntities1();
        TB_Sell tb_sell = new TB_Sell();  
        TB_Pur  tb_pur = new TB_Pur();
        BL.Methods methods=new BL.Methods();    

        public int id;
        double qtp,qtn,qtr;//Previous,new,required

        public FRM_SELL_ADD()
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
                dialog.txt_caption.Text = "product name required";
                dialog.Show();
            }
            else
            {
                // add
                qtp = Convert.ToDouble(txt_qt.Text);
                qtn = Convert.ToDouble(edt_qt.Text);
                qtr=qtp-qtn;
                if (id == 0)
                {
                    if(qtr>=0)
                    {
                        tb_sell.Sell_Name= edt_name.Text;
                        tb_sell.Sell_Cus=edt_cus.Text;
                        tb_sell.Sell_price=Convert.ToDouble(edt_sell.Text);
                        tb_sell.Sell_Qt = Convert.ToDouble(edt_qt.Text);
                        tb_sell.Sell_TPrice=(Convert.ToDouble(edt_qt.Text))*Convert.ToDouble(edt_sell.Text);
                        tb_sell.Sell_Date = DateTime.Now;
                        tb_pur.Pur_Qt = qtr;
                        db.TB_Sell.Add(tb_sell);

                        db.Entry(tb_pur).State = System.Data.Entity.EntityState.Modified;
                     

                        db.SaveChanges();
                        toast.txt_caption.Text = "Sold completed";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        label10.Visible = true;
                    }
                    
                    
                    
                }
               
            }

        }

        

        private void edt_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_pur = db.TB_Pur.Where(x => x.Pur_Name == edt_name.Text).FirstOrDefault();
            txt_buy.Text = tb_pur.Pur_Buy.ToString();
            txt_sell.Text = tb_pur.Pur_Sell.ToString();
            txt_qt.Text = tb_pur.Pur_Qt.ToString();
            edt_sell.Text = tb_pur.Pur_Sell.ToString();
        }

        private void FRM_PUR_ADD_Load(object sender, EventArgs e)
        {

        }

        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
            var rs1 = db.TB_Pur.Select(x => x.Pur_Name).ToList();
            var rs2 = db.TB_CuS.Select(x => x.Cus_name).ToList();
            edt_name.DataSource=rs1;
            edt_cus.DataSource=rs2;

            AutoCompleteStringCollection ACDC1=new AutoCompleteStringCollection();
            AutoCompleteStringCollection ACDC2=new AutoCompleteStringCollection();
            ACDC1.AddRange(rs1.ToArray());
            ACDC2.AddRange(rs2.ToArray());

            edt_name.AutoCompleteCustomSource=ACDC1;
            edt_cus.AutoCompleteCustomSource =ACDC2;

           
            

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
       
    }
}
