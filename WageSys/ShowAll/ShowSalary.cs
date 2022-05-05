using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageSys.ShowAll
{
    public partial class ShowSalary : Form
    {
        Model1 db = new Model1();
        public ShowSalary()
        {
            InitializeComponent();


            var deg = from p in db.SalaryLogs
                      orderby p.salaryLogID ascending
                      select new
                      {
                          salaryLog_ID = p.salaryLogID,
                          employeeId = p.Employee.employeeName,
                          salaray_year = p.salarayyear == null ? "" : p.salarayyear,
                          salary_Month = p.salaryMonth == null ? "" : p.salaryMonth,
                          allowance_Delay = p.allowanceDelay == null ? 0 : p.allowanceDelay,
                          committee_Amount = p.committeeAmount == null ? 0 : p.committeeAmount,
                          unemp_Gift = p.unempGift == null ? 0 : p.unempGift,
                          other_gift = p.othergift == null ? 0 : p.othergift,
                          insurance_tax = p.insurancetax == null ? 0 : p.insurancetax,
                          loan_discount = p.loandiscount == null ? 0 : p.loandiscount,
                          sanction_tax = p.sanctiontax == null ? 0 : p.sanctiontax,
                          exempt_tax = p.exempttax == null ? 0 : p.sanctiontax,
                          allowance_diff = p.allowancediff == null ? 0 : p.allowancediff,
                          past_years = p.pastyears == null ? 0 : p.pastyears,
                          paycar_use = p.paycaruse == null ? 0 : p.paycaruse,
                          basic_Salary = p.basicSalary == null ? 0 : p.basicSalary,
                          allowance_Secondment = p.allowanceSecondment == null ? 0 : p.allowanceSecondment,
                          total_Salary = p.totalSalary == null ? 0 : p.totalSalary,
                          socialSecutiy_Tax = p.socialSecutiyTax == null ? 0 : p.socialSecutiyTax,
                          salary_WorkContribution = p.salaryWorkContribution == null ? 0 : p.salaryWorkContribution,
                          salary_TreasurContribution = p.salaryTreasurContribution == null ? 0 : p.salaryTreasurContribution,
                          totalamount_social = p.totalamountsocial == null ? 0 : p.totalamountsocial,
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
                          Total_SalaryNet = p.TotalSalaryNet == null ? 0 : p.TotalSalaryNet
                          //salaryAbsent_Day = p.salaryAbsentDay == null ? 0 : p.salaryAbsentDay
                      };
            dataGridView1.DataSource = deg.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.ToString() == "")
            {

                var bind = (from p in db.SalaryLogs
                            orderby p.salaryLogID ascending
                            group p by new
                            {
                                salaryLog_ID = p.salaryLogID,
                                employeeId = p.Employee.employeeName,
                                salaray_year = p.salarayyear == null ? "" : p.salarayyear,
                                salary_Month = p.salaryMonth == null ? "" : p.salaryMonth,
                                allowance_Delay = p.allowanceDelay == null ? 0 : p.allowanceDelay,
                                committee_Amount = p.committeeAmount == null ? 0 : p.committeeAmount,
                                unemp_Gift = p.unempGift == null ? 0 : p.unempGift,
                                other_gift = p.othergift == null ? 0 : p.othergift,
                                insurance_tax = p.insurancetax == null ? 0 : p.insurancetax,
                                loan_discount = p.loandiscount == null ? 0 : p.loandiscount,
                                sanction_tax = p.sanctiontax == null ? 0 : p.sanctiontax,
                                exempt_tax = p.exempttax == null ? 0 : p.sanctiontax,
                                allowance_diff = p.allowancediff == null ? 0 : p.allowancediff,
                                past_years = p.pastyears == null ? 0 : p.pastyears,
                                paycar_use = p.paycaruse == null ? 0 : p.paycaruse,
                                basic_Salary = p.basicSalary == null ? 0 : p.basicSalary,
                                allowance_Secondment = p.allowanceSecondment == null ? 0 : p.allowanceSecondment,
                                total_Salary = p.totalSalary == null ? 0 : p.totalSalary,
                                socialSecutiy_Tax = p.socialSecutiyTax == null ? 0 : p.socialSecutiyTax,
                                salary_WorkContribution = p.salaryWorkContribution == null ? 0 : p.salaryWorkContribution,
                                salary_TreasurContribution = p.salaryTreasurContribution == null ? 0 : p.salaryTreasurContribution,
                                totalamount_social = p.totalamountsocial == null ? 0 : p.totalamountsocial,
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
                                Total_SalaryNet = p.TotalSalaryNet == null ? 0 : p.TotalSalaryNet

                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
            else
            {
                var bind = (from p in db.SalaryLogs
                            where p.Employee.employeeName.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower()) || 
                            p.salarayyear.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower()) 
                            orderby p.salaryLogID ascending
                            group p by new
                            {
                                salaryLog_ID = p.salaryLogID,
                                employeeId = p.Employee.employeeName,
                                salaray_year = p.salarayyear == null ? "" : p.salarayyear,
                                salary_Month = p.salaryMonth == null ? "" : p.salaryMonth,
                                allowance_Delay = p.allowanceDelay == null ? 0 : p.allowanceDelay,
                                committee_Amount = p.committeeAmount == null ? 0 : p.committeeAmount,
                                unemp_Gift = p.unempGift == null ? 0 : p.unempGift,
                                other_gift = p.othergift == null ? 0 : p.othergift,
                                insurance_tax = p.insurancetax == null ? 0 : p.insurancetax,
                                loan_discount = p.loandiscount == null ? 0 : p.loandiscount,
                                sanction_tax = p.sanctiontax == null ? 0 : p.sanctiontax,
                                exempt_tax = p.exempttax == null ? 0 : p.sanctiontax,
                                allowance_diff = p.allowancediff == null ? 0 : p.allowancediff,
                                past_years = p.pastyears == null ? 0 : p.pastyears,
                                paycar_use = p.paycaruse == null ? 0 : p.paycaruse,
                                basic_Salary = p.basicSalary == null ? 0 : p.basicSalary,
                                allowance_Secondment = p.allowanceSecondment == null ? 0 : p.allowanceSecondment,
                                total_Salary = p.totalSalary == null ? 0 : p.totalSalary,
                                socialSecutiy_Tax = p.socialSecutiyTax == null ? 0 : p.socialSecutiyTax,
                                salary_WorkContribution = p.salaryWorkContribution == null ? 0 : p.salaryWorkContribution,
                                salary_TreasurContribution = p.salaryTreasurContribution == null ? 0 : p.salaryTreasurContribution,
                                totalamount_social = p.totalamountsocial == null ? 0 : p.totalamountsocial,
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
                                Total_SalaryNet = p.TotalSalaryNet == null ? 0 : p.TotalSalaryNet
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
        }
    }
}
