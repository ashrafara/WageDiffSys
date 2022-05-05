using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;
using CrystalDecisions.CrystalReports.Engine;

namespace WageSys.Reports
{
    public partial class bank_view : Form
    {
        Model1 db = new Model1();

        public bank_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=WageSystem;User ID=sa;Password=ali123");
            bank_report rpt = new bank_report();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "WageSystem");
            rpt.SetParameterValue("month", textBox2.Text.ToString());
            rpt.SetParameterValue("year", textBox1.Text.ToString());
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
