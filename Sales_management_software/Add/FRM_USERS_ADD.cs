using Sales_management_software.DB;
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
    public partial class FRM_USERS_ADD: Form
    {
        // init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_Users  = new TB_Users();
        BL.Methods methods=new BL.Methods();    
        

        public int id;

        public FRM_USERS_ADD()
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

                    tb_Users.User_Name = edt_name.Text;
                    tb_Users.User_Pass = edt_pass.Text;
                    tb_Users.User_Roll = edt_roll.Text;
                    tb_Users.User_State = "False";
                    if (db.TB_Users.Where(X => (X.User_Name == tb_Users.User_Name && X.User_Pass == tb_Users.User_Pass)).FirstOrDefault() == null)
                    {
                        db.TB_Users.Add(tb_Users);
                        toast.txt_caption.Text = "A new user has been added";
                        db.SaveChanges();
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        dialog.Width = this.Width;
                        dialog.txt_caption.Text = "User already exists";
                        dialog.Show();
                    }
                }
                else
                {

                    tb_Users.ID = id;
                    tb_Users.User_Name = edt_name.Text;
                    tb_Users.User_Pass = edt_pass.Text;
                    tb_Users.User_Roll = edt_roll.Text;
                    tb_Users.User_State = "False";
                    
                    
                    db.Entry(tb_Users).State = System.Data.Entity.EntityState.Modified;
                    toast.txt_caption.Text = " user has been Modified";
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
