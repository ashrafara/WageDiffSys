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
    public partial class payroll_view : Form
    {
        Model1 db = new Model1();
        public payroll_view()
        {
            InitializeComponent();

            var emplpy = (from c in db.Banks
                          select new
                          {
                              c.mainBank,
                              c.branchBank,
                              c.bankId,
                          }).Distinct().ToList();
            comboBox1.DataSource = emplpy.ToList();
            comboBox1.DisplayMember = "mainBank";
            comboBox1.ValueMember = "bankId";

            comboBox2.DataSource = emplpy.ToList();
            comboBox2.DisplayMember = "branchBank";
            comboBox2.ValueMember = "bankId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReportDocument cryRpt = new ReportDocument();
            //SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=WageSystem;User ID=sa;Password=ali123");
            payroll_report rpt = new payroll_report();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "WageSystem");
            rpt.SetParameterValue("salaryMonth", textBox1.Text.ToString());
            rpt.SetParameterValue("salarayyear", textBox2.Text.ToString());
            rpt.SetParameterValue("bankId", comboBox1.SelectedValue);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = comboBox1.SelectedItem;
        }

        private void payroll_view_Load(object sender, EventArgs e)
        {

        }
    }
}
