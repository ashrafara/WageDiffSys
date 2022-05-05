using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace WageSys.Reports
{
    public partial class wandc_view : Form
    {
        public wandc_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=WageSystem;User ID=sa;Password=ali123");
            wandc_report rpt = new wandc_report();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "WageSystem");
            rpt.SetParameterValue("month", textBox1.Text.ToString());
            rpt.SetParameterValue("year", textBox2.Text.ToString());
            crystalReportViewer1.ReportSource = rpt;

        }

        private void wandc_view_Load(object sender, EventArgs e)
        {

        }
    }
}
