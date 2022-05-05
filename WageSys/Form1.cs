using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageSys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void اضافةعلاوةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.Adddegree frm = new Main.Adddegree();
            frm.ShowDialog();
        }

        private void تعديلعلاوةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.Editdegree frm = new Edit.Editdegree();
            frm.ShowDialog();

        }

        private void اضافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.AddBank frm = new Main.AddBank();
            frm.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.EditBank frm = new Edit.EditBank();
            frm.ShowDialog();
        }

        private void اضافةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Main.Addbranch frm = new Main.Addbranch();
            frm.ShowDialog();
        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit.EditBranch frm = new Edit.EditBranch();
            frm.ShowDialog();
        }

        private void اضافةموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.Addemployee frm = new Main.Addemployee();
            frm.ShowDialog();
        }

        private void تعديلموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.EditEmployee frm = new Edit.EditEmployee();
            frm.ShowDialog();
        }

        private void صرفمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.AddSalary frm = new Main.AddSalary();
            frm.ShowDialog();
        }

        private void تعديلمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.deleteSalary frm = new Edit.deleteSalary();
            frm.ShowDialog();
        }

        private void بطاقةمرتبلموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.salarycard_view frm = new Reports.salarycard_view();
            frm.ShowDialog();
        }

        private void الكشفالتحليليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.analysis_view frm = new Reports.analysis_view();
            frm.ShowDialog();
        }

        private void كشفالمصارفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.bank_view frm = new Reports.bank_view();
            frm.ShowDialog();
        }

        private void كشفالمضمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.socialtax_report frm = new Reports.socialtax_report();
            frm.ShowDialog();
        }

        private void كشفالجهادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.jihad_view frm = new Reports.jihad_view();
            frm.ShowDialog();
        }

        private void كشفالتضامنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.solidaritytax_view frm = new Reports.solidaritytax_view();
            frm.ShowDialog();
        }

        private void كشفمساهمةجهةالعملوالخزانةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.wandc_view frm = new Reports.wandc_view();
            frm.ShowDialog();
        }

        private void استمارةمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.payroll_view frm = new Reports.payroll_view();
            frm.ShowDialog();

        }

        private void حافظةالمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.portfilo_view frm = new Reports.portfilo_view();
            frm.ShowDialog();
        }

        private void شهادةمرتبلموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.emp_certificate_view fm = new Reports.emp_certificate_view();
            fm.ShowDialog();
        }

        private void الفرعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.Addbranch frm = new Main.Addbranch();
            frm.ShowDialog();
        }

        private void عرضكلالمصارفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAll.ShowBanks frm = new ShowAll.ShowBanks();
            frm.ShowDialog();
        }

        private void عرضالدرجاتوالعلاواتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAll.ShowDegree frm = new ShowAll.ShowDegree();
            frm.ShowDialog();
        }

        private void عرضالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAll.ShowEmployee frm = new ShowAll.ShowEmployee();
            frm.ShowDialog();
        }

        private void بياناتالموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.employee_view frm = new Reports.employee_view();
            frm.ShowDialog();
        }

        private void بطاقةالدفعالاخيرةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.last_report frm = new Reports.last_report();
            frm.ShowDialog();
        }
    }
}
