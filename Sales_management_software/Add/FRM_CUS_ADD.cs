﻿using Sales_management_software.DB;
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
    public partial class FRM_CUS_ADD: Form
    {
        // init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_CuS tb_cus = new TB_CuS();
        BL.Methods methods=new BL.Methods();    
        

        public int id;

        public FRM_CUS_ADD()
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
                dialog.txt_caption.Text = "customer name required";
                dialog.Show();
            }
            else
            {
                // check add or edit
                if (id == 0)
                {
                    //ADD
                    pic_cover.Image.Save(methods.ma,System.Drawing.Imaging.ImageFormat.Png);
                    tb_cus.Cus_name = edt_name.Text;
                    tb_cus.Cus_phone = edt_phone.Text;
                    tb_cus.Cus_location = edt_location.Text;
                    tb_cus.Cus_image = methods.convert_byte();
                    if (db.TB_CuS.Where(X => (X.Cus_name == tb_cus.Cus_name && X.Cus_phone == tb_cus.Cus_phone)).FirstOrDefault() == null)
                    {
                        db.TB_CuS.Add(tb_cus);
                        toast.txt_caption.Text = "A new customer has been added";
                        db.SaveChanges();
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        dialog.Width = this.Width;
                        dialog.txt_caption.Text = "customer name already exists";
                        dialog.Show();
                    }
                }
                else
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_cus.ID = id;
                    tb_cus.Cus_name = edt_name.Text;
                    tb_cus.Cus_phone = edt_phone.Text;
                    tb_cus.Cus_location = edt_location.Text;
                    tb_cus.Cus_image = methods.convert_byte();
                    db.Entry(tb_cus).State = System.Data.Entity.EntityState.Modified;
                    toast.txt_caption.Text = " customer has been Modified";
                    db.SaveChanges();
                    toast.Show();
                    this.Close();
                }
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            
        }
    }
}
