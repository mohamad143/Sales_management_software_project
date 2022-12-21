using DevExpress.XtraSplashScreen;
using Sales_management_software.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_management_software.PL
{
    public partial class FRM_START : SplashScreen
    { 
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_users = new TB_Users();
        Main main = new Main();
        PL.FRM_Login login = new FRM_Login();
        public FRM_START()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_users = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();
            if (tb_users != null)
            {
                main.lb_UserName.Text = tb_users.User_Name;
                main.lb_roll.Text = tb_users.User_Roll;
                main.Show();
            }
            else
            {
                login.Show();
                
            }
            this.Hide();
            timer1.Enabled = false;
        }
    }
}