using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageSys.Reports
{
    public partial class employee_view : Form
    {
        Model1 db = new Model1();

        public employee_view()
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
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "WageSystem");
            rpt.SetParameterValue("id", comboBox1.SelectedValue);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
