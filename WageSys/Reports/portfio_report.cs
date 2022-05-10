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
using CrystalDecisions.CrystalReports.Engine;

namespace WageSys.Reports
{
    public partial class portfio_report : Form
    {
        Model1 db = new Model1();

        public portfio_report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=WageSystem;User ID=sa;Password=ali123");
            Salarprofile_report rpt = new Salarprofile_report();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "WageSystem");
            rpt.SetParameterValue("salaryMonth", textBox1.Text.ToString());
            rpt.SetParameterValue("salarayyear", textBox2.Text.ToString());
           // rpt.SetParameterValue("bankId", comboBox1.SelectedValue);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
