using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace WageSys.Edit
{
    public partial class EditEmployee : Form
    {
        Model1 db = new Model1();

        public EditEmployee()
        {
            InitializeComponent();

            var emplpy = (from c in db.EmployeeDegreees
                          select new { c.degreeNumber, c.degreeId }).ToList();
            cbDegreee.DataSource = emplpy.ToList();
            cbDegreee.DisplayMember = "degreeNumber";
            cbDegreee.ValueMember = "degreeId";

            var ban = (from c in db.Banks
                       select new { c.mainBank, c.branchBank, c.bankId }).ToList();
            coBank.DataSource = ban.ToList();
            coBank.DisplayMember = "mainBank";
            coBank.ValueMember = "bankId";

            coBankBranch.DataSource = ban.ToList();
            coBankBranch.DisplayMember = "branchBank";
            coBankBranch.ValueMember = "bankId";


            var emps = from p in db.Employees
                       select new
                       {
                           employee_Id = p.employeeId,
                           employee_Name = p.employeeName == null ? "" : p.employeeName,
                           employee_Nationality = p.employeeNationality == null ? "" : p.employeeNationality,
                           employee_NationalNo = p.employeeNationalNo == null ? 0 : p.employeeNationalNo,
                           employee_InsuranceNo = p.employeeInsuranceNo == null ? 0 : p.employeeInsuranceNo,
                           employee_Departement = p.employeeDepartement == null ? "" : p.employeeDepartement,
                           employee_Division = p.employeeDivision == null ? "" : p.employeeDivision,
                           employement_Name = p.employementName == null ? "" : p.employementName,
                           degree_Id = p.EmployeeDegreee.degreeNumber == null ? "" : p.EmployeeDegreee.degreeNumber,
                           emlpoyee_Bouns = p.emlpoyeeBouns == null ? 0 : p.emlpoyeeBouns,
                           employee_State = p.employeeState == null ? "" : p.employeeState,
                           main_Bank = p.Bank.mainBank == null ? "" : p.Bank.mainBank,
                           branch_Bank = p.Bank.branchBank == null ? "" : p.Bank.branchBank,
                           employee_BankNumber = p.employeeBankNumber == null ? "" : p.employeeBankNumber,
                           employee_StartDate = p.employeeStartDate,
                           employee_Salary = p.employeeSalary == null ? "" : p.employeeSalary,
                           employeeDegree_Assign = p.employeeDegreeAssign == null ? 0 : p.employeeDegreeAssign,
                           employeeBouns_Assign = p.employeeBounsAssign == null ? 0 : p.employeeBounsAssign,
                           employee_Martial = p.employeeMartial == null ? "" : p.employeeMartial,
                           child_num = p.childnum == null ? 0 : p.childnum
                       };
            dataGridView1.DataSource = emps.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم الموظف ";
            dataGridView1.Columns[2].HeaderText = "الجنسية";
            dataGridView1.Columns[3].HeaderText = "الرقم الوطني ";
            dataGridView1.Columns[4].HeaderText = "الرقم الضماني ";
            dataGridView1.Columns[5].HeaderText = "الادارة ";
            dataGridView1.Columns[6].HeaderText = "القسم ";
            dataGridView1.Columns[7].HeaderText = "اسم الوظيفية ";
            dataGridView1.Columns[8].HeaderText = "الدرجة  ";
            dataGridView1.Columns[9].HeaderText = "العلاوة ";
            dataGridView1.Columns[10].HeaderText = "حال الموظف ";
            dataGridView1.Columns[11].HeaderText = "المصرف ";
            dataGridView1.Columns[12].HeaderText = "الفرع ";
            dataGridView1.Columns[13].HeaderText = "الرقم الحسابي ";
            dataGridView1.Columns[14].HeaderText = "تاريخ بداية العمل ";
            dataGridView1.Columns[15].HeaderText = "حال المرتب ";
            dataGridView1.Columns[16].HeaderText = "الدرجة المنتدب اليها ";
            dataGridView1.Columns[17].HeaderText = "العلاوة المنتدب اليها ";
            dataGridView1.Columns[18].HeaderText = "الحالة الاجتماعية ";
            dataGridView1.Columns[19].HeaderText = "عدد الابناء";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic degree = cbDegreee.SelectedValue;
            dynamic mbank = coBank.SelectedValue;
            dynamic bbank = coBankBranch.SelectedValue;
            dynamic empType = comboBox1.SelectedItem;
            dynamic stt = comboBox2.SelectedItem;
            dynamic ms = comboBox3.SelectedItem;
            dynamic cdepar = cbDepartement.SelectedItem;
            dynamic cdivision = cbDivision.SelectedItem;

            var employ = new Employee
            {
                employeeId = int.Parse(textBox1.Text),
                employeeName = string.IsNullOrEmpty(txtemployeeName.Text) ? "" : txtemployeeName.Text,
                employeeNationality = string.IsNullOrEmpty(txtNationality.Text) ? "" : txtNationality.Text,
                employeeNationalNo = string.IsNullOrEmpty(txtemployeeNationalNumber.Text) ? (decimal?)0 : Convert.ToDecimal(txtemployeeNationalNumber.Text),
                employeeInsuranceNo = string.IsNullOrEmpty(txtemployeeInsuranceNumber.Text) ? (decimal?)0 : Convert.ToDecimal(txtemployeeInsuranceNumber.Text),
                employeeBankNumber = string.IsNullOrEmpty(txtemployeeBankNumber.Text) ? "" : txtemployeeBankNumber.Text,
                employeeDepartement = cdepar,
                employeeDivision = cdivision,
                employementName = string.IsNullOrEmpty(txtemployementName.Text) ? "" : txtemployementName.Text,
                degreeId = degree,
                emlpoyeeBouns = int.Parse(comboBox4.SelectedItem.ToString()),
                employeeState = empType,
                employeeSalary = stt,
                employeeStartDate = Convert.ToDateTime(dateTimePicker1.Text),
                bankId = mbank,
                childnum = string.IsNullOrEmpty(txtchildno.Text) ? (int?)0 : Convert.ToInt32(txtchildno.Text),
                employeeDegreeAssign = string.IsNullOrEmpty(txtdegreAssign.Text) ? (int?)0 : Convert.ToInt32(txtdegreAssign.Text),
                employeeBounsAssign = string.IsNullOrEmpty(txtbounsAssign.Text) ? (int?)0 : Convert.ToInt32(txtbounsAssign.Text),
                employeeMartial = ms
            };
            db.Employees.AddOrUpdate(employ);
            db.SaveChanges();
            MessageBox.Show("تم التعديل");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                txtemployeeName.Text = row.Cells[1].Value.ToString();
                txtNationality.Text = row.Cells[2].Value.ToString();
                txtemployeeNationalNumber.Text = row.Cells[3].Value.ToString();
                txtemployeeInsuranceNumber.Text = row.Cells[4].Value.ToString();
                cbDepartement.Text = row.Cells[5].Value.ToString();
                cbDivision.Text = row.Cells[6].Value.ToString();
                txtemployementName.Text = row.Cells[7].Value.ToString();
                cbDegreee.Text = row.Cells[8].Value.ToString();
                comboBox4.Text = row.Cells[9].Value.ToString();
                comboBox1.Text = row.Cells[10].Value.ToString();
                coBank.Text = row.Cells[11].Value.ToString();
                coBankBranch.Text = row.Cells[12].Value.ToString();
                txtemployeeBankNumber.Text = row.Cells[13].Value.ToString();
                dateTimePicker1.Text = row.Cells[14].Value.ToString();
                comboBox2.Text = row.Cells[15].Value.ToString();
                txtdegreAssign.Text = row.Cells[16].Value.ToString();
                txtbounsAssign.Text = row.Cells[17].Value.ToString();
                comboBox3.Text = row.Cells[18].Value.ToString();
                txtchildno.Text= row.Cells[19].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var deletedemply = (from c in db.Employees
                                where c.employeeId == id
                                select c).Single();
            db.Employees.Remove(deletedemply);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
        }

        private void coBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            coBankBranch.SelectedItem = coBank.SelectedItem;
        }

        private void coBankBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            coBank.SelectedItem = coBankBranch.SelectedItem;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
        private void txtemployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtemployeeInsuranceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtemployeeNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtemployementName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtchildno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtdegreAssign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtbounsAssign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
