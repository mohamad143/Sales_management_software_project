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
    public partial class FRM_SUPP_ADD: Form
    {
        // init
        DB_SMPEntities1 db=new DB_SMPEntities1();
        TB_Supp tb_supp = new TB_Supp();
        BL.Methods methods=new BL.Methods();    
        

        public int id;

        public FRM_SUPP_ADD()
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
                    pic_cover.Image.Save(methods.ma,System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_email.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    db.TB_Supp.Add(tb_supp);
                    toast.txt_caption.Text = "A new supp has been added";
                    db.SaveChanges();
                    toast.Show();
                    this.Close();
                }
                else
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.ID = id;
                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_email.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    db.Entry(tb_supp).State = System.Data.Entity.EntityState.Modified;
                    toast.txt_caption.Text = " supp has been Modified";
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
    }
}
