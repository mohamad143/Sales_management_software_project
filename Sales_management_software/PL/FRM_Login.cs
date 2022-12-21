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
    public partial class FRM_Login : Form
    {
        // init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_Users = new TB_Users();
        Main main = new Main();
        

        public FRM_Login()
        {
            InitializeComponent();
        }
        // add or edit
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
          

            if (edt_name.Text == "" || edt_pass.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "user name and password required";
                dialog.Show();
            }
            else
            {
                //login

                tb_Users = db.TB_Users.Where(x => x.User_Name == edt_name.Text && x.User_Pass == edt_pass.Text).FirstOrDefault();
                if(tb_Users != null)
                {
                    tb_Users.User_State ="True";
                    db.Entry(tb_Users).State = System.Data.Entity.EntityState.Modified;
                    main.lb_UserName.Text = tb_Users.User_Name;
                    main.lb_roll.Text=tb_Users.User_Roll; 
                    main.Enabled= true;
                    db.SaveChanges();
                    main.Show();
                    this.Close();
                }
                else if(MessageBox.Show("try again?", "Faild Login", MessageBoxButtons.YesNo)== DialogResult.Yes)
                {


                    
                }
                else
                {
                    MessageBox.Show("bye bye");
                    Environment.Exit(0);
                }


            }

        }
        

        private void FRM_Login_Load(object sender, EventArgs e)
        {
              

        }

        

       
    }
}
