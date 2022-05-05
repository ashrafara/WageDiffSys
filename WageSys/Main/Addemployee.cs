using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageSys.Main
{
    public partial class Addemployee : Form
    {
        Model1 db = new Model1();

        public Addemployee()
        {
            InitializeComponent();

            var emplpy = (from c in db.EmployeeDegreees
                          select new { c.degreeNumber, c.degreeId }).Distinct().ToList();
            cbDegreee.DataSource = emplpy.ToList();
            cbDegreee.DisplayMember = "degreeNumber";
            cbDegreee.ValueMember = "degreeId";



            var ban = (from c in db.Banks
                       select new { c.mainBank, c.branchBank, c.bankId }).ToList();
            coBank.DataSource = ban.Distinct().ToList();
            coBank.DisplayMember = "mainBank";
            coBank.ValueMember = "bankId";

            coBankBranch.DataSource = ban.Distinct().ToList();
            coBankBranch.DisplayMember = "branchBank";
            coBankBranch.ValueMember = "bankId";
        }

        private void Addemployee_Load(object sender, EventArgs e)
        {

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
            dynamic bn = comboBox4.SelectedItem;
            dynamic cdepar = cbDepartement.SelectedItem;
            dynamic cdivision = cbDivision.SelectedItem;

            foreach (Control c in this.Controls)
            {
                if (txtemployeeName.Text == "" || txtNationality.Text == "" || txtemployeeNationalNumber.Text == "" || txtemployeeInsuranceNumber.Text == "" ||
                    txtemployeeBankNumber.Text == "" || txtemployementName.Text== "" || txtchildno.Text== "")
                {
                    MessageBox.Show("الرجاء تعبئة الخانات الفارغة");
                }
                else
                {

                    var employ = new Employee
                    {
                        employeeName = string.IsNullOrEmpty(txtemployeeName.Text) ? "" : txtemployeeName.Text,
                        employeeNationality = string.IsNullOrEmpty(txtNationality.Text) ? "" : txtNationality.Text,
                        employeeNationalNo = string.IsNullOrEmpty(txtemployeeNationalNumber.Text) ? (decimal?)0 : Convert.ToDecimal(txtemployeeNationalNumber.Text),
                        employeeInsuranceNo = string.IsNullOrEmpty(txtemployeeInsuranceNumber.Text) ? (decimal?)0 : Convert.ToDecimal(txtemployeeInsuranceNumber.Text),
                        employeeBankNumber = string.IsNullOrEmpty(txtemployeeBankNumber.Text) ? "" : txtemployeeBankNumber.Text,
                        employeeDepartement = cdepar,
                        employeeDivision = cdivision,
                        employementName = string.IsNullOrEmpty(txtemployementName.Text) ? "" : txtemployementName.Text,
                        degreeId = degree,
                        emlpoyeeBouns = bn,
                        employeeState = empType,
                        employeeSalary = stt,
                        employeeStartDate = Convert.ToDateTime(dateTimePicker1.Text),
                        bankId = mbank,
                        branchId = bbank,
                        employeeMartial = ms,
                        childnum = string.IsNullOrEmpty(txtchildno.Text) ? (int?)0 : Convert.ToInt32(txtchildno.Text),
                        employeeDegreeAssign = string.IsNullOrEmpty(txtdegreAssign.Text) ? (int?)0 : Convert.ToInt32(txtdegreAssign.Text),
                        employeeBounsAssign = string.IsNullOrEmpty(txtbounsAssign.Text) ? (int?)0 : Convert.ToInt32(txtbounsAssign.Text)
                    };
                    db.Employees.Add(employ);
                    db.SaveChanges();
                    MessageBox.Show("تم الاضافة");
                }
            }
            
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void coBank_SelectedIndexChanged(object sender, EventArgs e)
        {

            coBankBranch.SelectedItem = coBank.SelectedItem;
        }

        private void coBankBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            coBank.SelectedItem = coBankBranch.SelectedItem;
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

        private void txtemployeeBankNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

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
