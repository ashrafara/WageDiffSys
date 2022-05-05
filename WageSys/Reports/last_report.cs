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
    public partial class last_report : Form
    {
        Model1 db = new Model1();
        public last_report()
        {
            InitializeComponent();

            var emplpy = (from c in db.Employees
                          select new
                          {
                              c.employeeName,
                              c.employeeId
                          }).ToList();
            comboBox1.DataSource = emplpy.ToList();
            comboBox1.DisplayMember = "employeeName";
            comboBox1.ValueMember = "employeeId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReportDocument cryRpt = new ReportDocument();
            //SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=WageSystem;User ID=sa;Password=ali123");
            CrystalReport2 rpt = new CrystalReport2();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "WageSystem");
            rpt.SetParameterValue("empId", comboBox1.SelectedValue);
            rpt.SetParameterValue("month", textBox1.Text.ToString());
            rpt.SetParameterValue("year", textBox2.Text.ToString());
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
