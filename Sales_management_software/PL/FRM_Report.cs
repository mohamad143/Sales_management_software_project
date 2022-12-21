using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Sales_management_software.EPL;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using Sales_management_software.Reports;

namespace Sales_management_software.PL
{
    public partial class FRM_Report : Form
    {

        public FRM_Report()
        {

            InitializeComponent();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            report.ShowPreview();
        }
        private void btn_Customers_report_Click(object sender, EventArgs e)
        {

            XtraReport3 report3 = new XtraReport3();
            report3.ShowPreview();
        }

        private void btnn_Purchases_report_Click(object sender, EventArgs e)
        {
            XtraReport2 report2 = new XtraReport2();
            report2.ShowPreview();
        }

        private void btn_Suppliers_report_Click(object sender, EventArgs e)
        {
            XtraReport4 report4 = new XtraReport4();
            report4.ShowPreview();

        }
    }




}
