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

using Sales_management_software.DB;

namespace Sales_management_software.PL
{
    public partial class FRM_CAT_ADD : Form
    {
        // init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_CAT tb_cat = new TB_CAT();
        BL.Methods methods=new BL.Methods();    
        PL.FRM_Cat frm_Cat = new PL.FRM_Cat();
     

        public int id;

        public FRM_CAT_ADD()
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
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.CAT_Cover = methods.convert_byte();
                    if (db.TB_CAT.Where(X => (X.CAT_Name == tb_cat.CAT_Name)).FirstOrDefault() == null)
                    {
                        db.TB_CAT.Add(tb_cat);
                        db.SaveChanges();
                        toast.txt_caption.Text = "A new category has been added";
                        toast.Show();
                        db = new DB_SMPEntities();
                        frm_Cat.gridControl1.DataSource = db.TB_CAT.ToList();
                        this.Close();
                    }
                    else
                    {
                        dialog.Width = this.Width;
                        dialog.txt_caption.Text = "category name already exists";
                        dialog.Show();
                    }
                }
                else
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.ID= id;
                    tb_cat.CAT_Cover = methods.convert_byte();
                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "A category has been Modified";
                    toast.Show();
                    db = new DB_SMPEntities();
                    frm_Cat.gridControl1.DataSource = db.TB_CAT.ToList();
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
