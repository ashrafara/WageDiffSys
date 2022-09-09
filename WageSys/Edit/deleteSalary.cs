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
    public partial class deleteSalary : Form
    {
        Model1 db = new Model1();
        SalaryLog sl = new SalaryLog();

        public deleteSalary()
        {
            InitializeComponent();

            var emplpy = (from c in db.Employees
                          join s in db.EmployeeDegreees on c.degreeId equals s.degreeId
                          select new
                          {
                              c.employeeName,
                              c.EmployeeDegreee.degreeNumber,
                              c.emlpoyeeBouns,
                              c.employeeState,
                              s.bounsNumber,
                              s.degreeAmount,
                              s.degreeId,
                              c.employeeId
                          }).ToList();
            cbemployeeId.DataSource = emplpy.ToList();
            cbemployeeId.DisplayMember = "employeeName";
            cbemployeeId.ValueMember = "employeeId";

            cbBouns.DataSource = emplpy.ToList();
            cbBouns.DisplayMember = "emlpoyeeBouns";
            cbBouns.ValueMember = "employeeId";

            cbdegree.DataSource = emplpy.ToList();
            cbdegree.DisplayMember = "degreeNumber";
            cbdegree.ValueMember = "employeeId";

            cbemploymentType.DataSource = emplpy.ToList();
            cbemploymentType.DisplayMember = "employeeState";
            cbemploymentType.ValueMember = "employeeId";

            cbannualBounsId.DataSource = emplpy.ToList();
            cbannualBounsId.DisplayMember = "bounsNumber";
            cbannualBounsId.ValueMember = "degreeId";


            cbdegreeamount.DataSource = emplpy.ToList();
            cbdegreeamount.DisplayMember = "degreeAmount";
            cbdegreeamount.ValueMember = "degreeId";

            var deg = from p in db.SalaryLogs
                      orderby p.salaryLogID ascending
                      select new
                      {
                          salaryLog_ID = p.salaryLogID,
                          employeeId = p.Employee.employeeName,
                          salaray_year = p.salarayyear == null ? "" : p.salarayyear,
                          salary_Month = p.salaryMonth == null ? "" : p.salaryMonth,
                          sal_type = p.saltype,
                          allowance_Delay = p.allowanceDelay == null ? 0 : p.allowanceDelay,
                          committee_Amount = p.committeeAmount == null ? 0 : p.committeeAmount,
                          unemp_Gift = p.unempGift == null ? 0 : p.unempGift,
                          other_gift = p.othergift == null ? 0 : p.othergift,
                          insurance_tax = p.insurancetax == null ? 0 :p.insurancetax,
                          loan_discount = p.loandiscount == null ? 0 : p.loandiscount,
                          sanction_tax = p.sanctiontax == null ? 0 : p.sanctiontax,
                          exempt_tax = p.exempttax == null ? 0 : p.sanctiontax,
                          allowance_diff = p.allowancediff == null ? 0 : p.allowancediff,
                          past_years = p.pastyears == null ? 0 : p.pastyears,
                          paycar_use = p.paycaruse == null ? 0 : p.paycaruse,
                          basic_Salary = p.basicSalary == null ? 0 : p.basicSalary,
                          allowance_Secondment = p.allowanceSecondment == null ? 0 : p.allowanceSecondment,
                          addsecondement = p.addsecondement == null ? 0 : p.addsecondement,
                          salaryAbsent_Day = p.salaryAbsentDay == null ? 0 : p.salaryAbsentDay,
                          absentamount = p.absentamount == null ? 0 : p.absentamount,
                          total_Salary = p.totalSalary == null ? 0 : p.totalSalary,
                          socialSecutiy_Tax = p.socialSecutiyTax == null ? 0 : p.socialSecutiyTax,
                          salary_WorkContribution = p.salaryWorkContribution == null ? 0 : p.salaryWorkContribution,
                          salary_TreasurContribution = p.salaryTreasurContribution == null ? 0 : p.salaryTreasurContribution,
                          totalamount_social = p.totalamountsocial == null ? 0 :p.totalamountsocial,
                          solidarity_Tax = p.solidarityTax == null ? 0 : p.solidarityTax,
                          totalamount_jihad = p.totalamountjihad == null ? 0 : p.totalamountjihad,
                          jihad_Tax = p.jihadTax == null ? 0 : p.jihadTax,
                          servicebox_tax = p.serviceboxtax == null ? 0 : p.serviceboxtax,
                          total_income = p.totalincome == null ? 0 : p.totalincome,
                          income5_tax = p.income5tax == null ? 0 : p.income5tax,
                          income10_tax = p.income10tax == null ? 0 : p.income10tax,
                          totalincome_tax = p.totalincometax == null ? 0 : p.totalincometax,
                          Total_Allowanace = p.TotalAllowanace == null ? 0 : p.TotalAllowanace,
                          totalTax = p.totalTax == null ? 0 : p.totalTax,
                          Total_SalaryNet = p.TotalSalaryNet == null ? 0 : p.TotalSalaryNet,
                          
                          salaryletter = p.salaryletter == null ? "" : p.salaryletter
                      };
            dataGridView1.DataSource = deg.ToList();
            //dataGridView1.Columns[0].HeaderText = "ر.م";
            //dataGridView1.Columns[1].HeaderText = "اسم الموظف";
            //dataGridView1.Columns[2].HeaderText = " السنة";
            //dataGridView1.Columns[3].HeaderText = "الشهر";
            //dataGridView1.Columns[4].HeaderText = " المرتب الاساسي";
            //dataGridView1.Columns[5].HeaderText = "فروقات متاخرة";
            //dataGridView1.Columns[6].HeaderText = "علاوة ندب";
            //dataGridView1.Columns[7].HeaderText = "مكافاة اللجان";
            //dataGridView1.Columns[8].HeaderText = "اجمالي المرتب";
            //dataGridView1.Columns[9].HeaderText = "ضريبة الجهاد";
            //dataGridView1.Columns[10].HeaderText = "المضمون";
            //dataGridView1.Columns[11].HeaderText = "ضريبة التضامن";
            //dataGridView1.Columns[12].HeaderText = "مساهمة جهة العمل";
            //dataGridView1.Columns[13].HeaderText = "مساهمة الخزانة";
            //dataGridView1.Columns[14].HeaderText = "مجموع المساهمات";
            //dataGridView1.Columns[15].HeaderText = "صافي المرتب";
            //dataGridView1.Columns[16].HeaderText = "مجموع الضرائب";
            //dataGridView1.Columns[17].HeaderText = "مجموع العلاوات";
            //dataGridView1.Columns[18].HeaderText = "تاريخ الغياب";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                cbemployeeId.Text = row.Cells[1].Value.ToString();
                txtyear.Text = row.Cells[2].Value.ToString();
                txtrmonth.Text = row.Cells[3].Value.ToString();
                saltype.Text= row.Cells[4].Value.ToString();
                txtallowanceDelay.Text = row.Cells[5].Value.ToString();
                txtcommittee.Text = row.Cells[6].Value.ToString();
                txtunempGift.Text = row.Cells[7].Value.ToString();
                txtothergift.Text = row.Cells[8].Value.ToString();
                txtinsurancetax.Text = row.Cells[9].Value.ToString();
                txtloandiscount.Text = row.Cells[10].Value.ToString();
                txtsancted.Text = row.Cells[11].Value.ToString();
                txtexempttax.Text = row.Cells[12].Value.ToString();
                txtallowancediff.Text = row.Cells[13].Value.ToString();
                txtpastyears.Text = row.Cells[14].Value.ToString();
                txtpaycaruse.Text = row.Cells[15].Value.ToString();
                txtBasicSalary.Text = row.Cells[16].Value.ToString();
                txtallowanceSecondment.Text = row.Cells[17].Value.ToString();
                txtaddSecond.Text = row.Cells[18].Value.ToString();
                txtAbsentDay.Text= row.Cells[19].Value.ToString();
                txtabsentamount.Text= row.Cells[20].Value.ToString();

                txtTotalSalary.Text = row.Cells[21].Value.ToString();
                txtSocialSecurityTax.Text = row.Cells[22].Value.ToString();
                txtsalarysalaryWorkContribution.Text = row.Cells[23].Value.ToString();
                txtsalaryTreasurContribution.Text = row.Cells[24].Value.ToString();
                txttotalsocailtax.Text = row.Cells[25].Value.ToString();
                txtsolidarityTax.Text = row.Cells[26].Value.ToString();
                txtamountjihad.Text = row.Cells[27].Value.ToString();
                txtJihadTax.Text = row.Cells[28].Value.ToString();
                txtservicebox.Text = row.Cells[29].Value.ToString();
                txtincometax.Text = row.Cells[30].Value.ToString();
                txtincome5tax.Text = row.Cells[31].Value.ToString();
                txtincome10tax.Text = row.Cells[32].Value.ToString();
                txttotalincometax.Text = row.Cells[33].Value.ToString();
                txtTotalAllowanace.Text = row.Cells[34].Value.ToString();
                txtTotalTaxes.Text = row.Cells[35].Value.ToString();
                txtNetSalary.Text = row.Cells[36].Value.ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Text);
            var deletedemply = (from c in db.SalaryLogs
                                where c.salaryLogID == id
                                select c).Single();
            db.SalaryLogs.Remove(deletedemply);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
            dataGridView1.Update();
            dataGridView1.Refresh();
            ClearData();
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = db.SalaryLogs.Local;

        }

        private void تعديل_Click(object sender, EventArgs e)
        {
            dynamic empId = cbemployeeId.SelectedValue;
            dynamic boundId = cbBouns.SelectedValue;
            dynamic degreeId = cbdegree.SelectedValue;
            dynamic empType = cbemploymentType.SelectedValue;
            dynamic bounsAmount = cbannualBounsId.SelectedValue;
            dynamic degreeAmount = cbdegreeamount.SelectedValue;

                    var salary = new SalaryLog
                    {
                        salaryLogID= int.Parse(textBox1.Text),
                        employeeId = empId,
                        salarayyear = txtyear.Text,
                        salaryMonth = txtrmonth.Text,
                        jihadTax = double.Parse(txtJihadTax.Text),
                        socialSecutiyTax = double.Parse(txtSocialSecurityTax.Text),
                        solidarityTax = double.Parse(txtsolidarityTax.Text),
                        allowanceDelay = string.IsNullOrEmpty(txtallowanceDelay.Text) ? (double?)0 : double.Parse(txtallowanceDelay.Text),
                        allowanceSecondment = double.Parse(txtallowanceSecondment.Text),
                        basicSalary = double.Parse(txtBasicSalary.Text),
                        totalSalary = double.Parse(txtTotalSalary.Text),
                        TotalSalaryNet = double.Parse(txtNetSalary.Text),
                        salaryWorkContribution = double.Parse(txtsalarysalaryWorkContribution.Text),
                        salaryTreasurContribution = double.Parse(txtsalaryTreasurContribution.Text),
                        totalamountsocial = string.IsNullOrEmpty(txttotalsocailtax.Text) ? (double?)0 : double.Parse(txttotalsocailtax.Text),
                        totalamountjihad = string.IsNullOrEmpty(txtamountjihad.Text) ? (double?)0 : double.Parse(txtamountjihad.Text),
                        serviceboxtax = double.Parse(txtservicebox.Text),
                        exempttax = string.IsNullOrEmpty(txtexempttax.Text) ? (double?)0 : double.Parse(txtexempttax.Text),
                        totalincometax = string.IsNullOrEmpty(txtincometax.Text) ? (double?)0 : double.Parse(txtincometax.Text),
                        income5tax = string.IsNullOrEmpty(txtincome5tax.Text) ? (double?)0 : double.Parse(txtincome5tax.Text),
                        income10tax = string.IsNullOrEmpty(txtincome10tax.Text) ? (double?)0 : double.Parse(txtincome10tax.Text),
                        totalincome = string.IsNullOrEmpty(txttotalincometax.Text) ? (double?)0 : double.Parse(txttotalincometax.Text),
                        allowancediff = string.IsNullOrEmpty(txtallowancediff.Text) ? (double?)0 : double.Parse(txtallowancediff.Text),
                        pastyears = string.IsNullOrEmpty(txtpastyears.Text) ? (double?)0 : double.Parse(txtpastyears.Text),
                        loandiscount = string.IsNullOrEmpty(txtloandiscount.Text) ? (double?)0 : double.Parse(txtloandiscount.Text),
                        totalTax = double.Parse(txtTotalTaxes.Text),
                        TotalAllowanace = double.Parse(txtTotalAllowanace.Text),
                        committeeAmount = string.IsNullOrEmpty(txtcommittee.Text) ? (double?)0 : double.Parse(txtcommittee.Text),
                        unempGift = string.IsNullOrEmpty(txtunempGift.Text) ? (double?)0 : double.Parse(txtunempGift.Text),
                        othergift = string.IsNullOrEmpty(txtothergift.Text) ? (double?)0 : double.Parse(txtothergift.Text),
                        insurancetax = string.IsNullOrEmpty(txtinsurancetax.Text) ? (double?)0 : double.Parse(txtinsurancetax.Text),
                        sanctiontax = string.IsNullOrEmpty(txtsancted.Text) ? (double?)0 : double.Parse(txtsancted.Text),
                        employeeDegree = degreeId,
                        employeeBouns = boundId,
                        absentamount = string.IsNullOrEmpty(txtabsentamount.Text) ? (double?)0 : double.Parse(txtabsentamount.Text),
                        addsecondement = string.IsNullOrEmpty(txtaddSecond.Text) ? (double?)0 : double.Parse(txtaddSecond.Text),
                        salaryAbsentDay = string.IsNullOrEmpty(txtAbsentDay.Text) ? (double?)0 : double.Parse(txtAbsentDay.Text),
                        salaryDate = Convert.ToDateTime(dateTimePicker1.Text),
                        salaryTotalContribution = double.Parse(txtsalarysalaryWorkContribution.Text) + double.Parse(txtsalaryTreasurContribution.Text),
                        paycaruse = string.IsNullOrEmpty(txtpaycaruse.Text) ? (double?)0 : double.Parse(txtpaycaruse.Text),
                        cheaqueNum = string.IsNullOrEmpty(txtcheque.Text) ? (int?)0 : int.Parse(txtcheque.Text),
                        houseloan = string.IsNullOrEmpty(txthouseloan.Text) ? (double?)0 : double.Parse(txthouseloan.Text),
                        salaryletter = txtArabicWord.Text, 
                        saltype= saltype.SelectedItem.ToString()
                    };
                    db.SalaryLogs.AddOrUpdate(salary);
                    db.SaveChanges();
                    MessageBox.Show("تم الاضافة");

        }

        private void deleteSalary_Load(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {


        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dataGridView1.CurrentCell.Value = null;
                dataGridView1.CurrentCell.Selected = false;
            }
        }
    }
}
