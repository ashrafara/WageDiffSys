using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WageSys.BL;

namespace WageSys.Main
{
    public partial class AddSalary : Form
    {
        Model1 db = new Model1();
        private double AbsentDay;
        private double allowanceDelay;
        private double committee;
        int i;
        private double exempt;
        private double insurance;
        private double sancted;
        private double unempGiftt;
        private double othergiftt;
        private double allowancedifference;
        private double pastyearss;
        private double loandiscountt;

        private double paycaruses;
        double income5tax;
        double income10tax;
        private double addsecondd;
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        private double houseloans;

        public AddSalary()
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
            cbdegree.ValueMember = "degreeId";

            cbemploymentType.DataSource = emplpy.ToList();
            cbemploymentType.DisplayMember = "employeeState";
            cbemploymentType.ValueMember = "employeeId";

            cbannualBounsId.DataSource = emplpy.ToList();
            cbannualBounsId.DisplayMember = "bounsNumber";
            cbannualBounsId.ValueMember = "degreeId";


            cbdegreeamount.DataSource = emplpy.ToList();
            cbdegreeamount.DisplayMember = "degreeAmount";
            cbdegreeamount.ValueMember = "degreeId";

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

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dynamic empId = cbemployeeId.SelectedValue;
            dynamic boundId = cbBouns.SelectedValue;
            dynamic degreeId = cbdegree.SelectedValue;
            dynamic empType = cbemploymentType.SelectedValue;
            dynamic bounsAmount = cbannualBounsId.SelectedValue;
            dynamic degreeAmount = cbdegreeamount.SelectedValue;


            if (txtrmonth.Text =="" && txtyear.Text =="")
            {
                MessageBox.Show("الرجاء ادخال التاريخ والسنة");
            }
            else
            {

                var salary = new SalaryLog
                {
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
                    cheaqueNum= string.IsNullOrEmpty(txtcheque.Text) ? (int?)0 : int.Parse(txtcheque.Text),
                    houseloan = string.IsNullOrEmpty(txthouseloan.Text) ? (double?)0 : double.Parse(txthouseloan.Text),
                    salaryletter= txtArabicWord.Text

                };
                    db.SalaryLogs.Add(salary);
                    db.SaveChanges();
                    MessageBox.Show("تم الاضافة");
                    ClearTextBoxes();

            }

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            var empType = cbemploymentType.Text.ToString();
            var degrees = cbdegree.Text.ToString();
            var bounss = cbBouns.Text.ToString();
            var bounsamounts = cbannualBounsId.Text.ToString();
            var degreeamounts = cbdegreeamount.Text.ToString();

            if (empType.ToString() == "ندب")
            {
                txtallowanceSecondment.Visible = true;
                txtaddSecond.Visible = false;

                double bounsamonut = double.Parse(bounsamounts.ToString());

                double bounsno = double.Parse(bounss.ToString());

                double bouns = Math.Truncate(bounsamonut * bounsno*1000)/1000;

                double BasicSalary = double.Parse(degreeamounts.ToString()) + bouns;
                txtBasicSalary.Text = BasicSalary.ToString();

                double wg = BasicSalary / 30;
                double wage = Math.Truncate(wg*1000)/1000;
                txtWage.Text = wage.ToString();


                double amountt;
                if (double.TryParse(txtAbsentDay.Text, out amountt))
                {
                    AbsentDay += amountt;
                }

                double absentamount = Math.Truncate(wage * amountt*1000)/1000;
                txtabsentamount.Text= absentamount.ToString();

                double allowanceSecondment = BasicSalary * 0.1;
                txtallowanceSecondment.Text = allowanceSecondment.ToString();

                double amount;

                if (double.TryParse(txtallowanceDelay.Text, out amount))
                {
                    allowanceDelay += amount;
                }

                double committeamount;
                if (double.TryParse(txtcommittee.Text, out committeamount))
                {
                    committee += committeamount;
                }

                double exempttax;
                if (double.TryParse(txtexempttax.Text, out exempttax))
                {
                    exempt += exempttax;
                }

                double insurancetax;
                if (double.TryParse(txtinsurancetax.Text, out insurancetax))
                {
                    insurance += insurancetax;
                }

                double unempGift;
                if (double.TryParse(txtunempGift.Text, out unempGift))
                {
                    unempGiftt += unempGift;
                }

                double othergift;
                if (double.TryParse(txtothergift.Text, out othergift))
                {
                    othergiftt += othergift;
                }

                double allowancediff;
                if (double.TryParse(txtallowancediff.Text, out allowancediff))
                {
                    allowancedifference += allowancediff;
                }

                double pastyears;
                if (double.TryParse(txtpastyears.Text, out pastyears))
                {
                    pastyearss += pastyears;
                }

                double loandiscount;
                if (double.TryParse(txtloandiscount.Text, out loandiscount))
                {
                    loandiscountt += loandiscount;
                }

                double paycaruse;
                if (double.TryParse(txtpaycaruse.Text, out paycaruse))
                {
                    paycaruses += paycaruse;
                }

                double houseloan;
                if (double.TryParse(txthouseloan.Text, out houseloan))
                {
                    houseloans += houseloan;
                }

                double TotalAllowanace = allowanceSecondment + amount + committeamount + othergift + unempGift + allowancediff + pastyears;
                txtTotalAllowanace.Text = TotalAllowanace.ToString();

                double TotalSalary= BasicSalary + allowanceSecondment + amount + committeamount + othergift + unempGift + allowancediff + pastyears;
                txtTotalSalary.Text = TotalSalary.ToString();

                txtsancted.Text = txtabsentamount.Text;

                double SocialSecurityTax = Math.Truncate(TotalSalary * 37.5)/1000;
                txtSocialSecurityTax.Text = SocialSecurityTax.ToString();

                double solidarityTax = Math.Truncate(TotalSalary * 10)/1000;
                txtsolidarityTax.Text = solidarityTax.ToString();

                double jd = TotalSalary - (SocialSecurityTax + solidarityTax);
                double JihadTax = Math.Truncate( jd * 30)/1000;
                txtJihadTax.Text = JihadTax.ToString();

                double salarysalaryWorkContribution = Math.Truncate(TotalSalary * 105)/1000;
                txtsalarysalaryWorkContribution.Text = salarysalaryWorkContribution.ToString();

                double salaryTreasurContribution = Math.Truncate(TotalSalary * 7.5)/1000;
                txtsalaryTreasurContribution.Text = salaryTreasurContribution.ToString();

                double tas = SocialSecurityTax + salarysalaryWorkContribution + salaryTreasurContribution;
                txttotalsocailtax.Text = tas.ToString();

                double taj= TotalSalary - (SocialSecurityTax + solidarityTax);
                txtamountjihad.Text = taj.ToString();

                double serviceboxtax = Math.Truncate(BasicSalary* 15)/1000;
                txtservicebox.Text = serviceboxtax.ToString();

                double incometax = TotalSalary - SocialSecurityTax - solidarityTax - exempttax ;
                txtincometax.Text = incometax.ToString();

                double incomeTaxed = double.Parse(txtincometax.Text.ToString());
                if (incomeTaxed <= 1000)
                {
                    txtincome5tax.Text = Math.Truncate((incomeTaxed * 50)/1000).ToString();
                    txtincome10tax.Text = "0";
                }
                else
                {
                    double afterThousend;
                    afterThousend = incomeTaxed - 1000;
                    txtincome5tax.Text = (50).ToString();
                    txtincome10tax.Text = Math.Truncate((afterThousend * 100)/1000).ToString();
                }


                txttotalincometax.Text = (double.Parse(txtincome5tax.Text) + double.Parse(txtincome10tax.Text)).ToString();

                double TotalTaxes = SocialSecurityTax + solidarityTax + JihadTax + serviceboxtax + insurancetax + loandiscount + houseloan + double.Parse(txttotalincometax.Text) + double.Parse(txtsancted.Text);
                txtTotalTaxes.Text = TotalTaxes.ToString();

                double NetSalary = (TotalSalary - TotalTaxes) + paycaruse;
                txtNetSalary.Text = NetSalary.ToString();


            }
            else if(empType.ToString() == "الندب")
            {
                txtallowanceSecondment.Visible = false;
                txtaddSecond.Visible = true;

                double bounsamonut = double.Parse(bounsamounts.ToString());

                double bounsno = double.Parse(bounss.ToString());

                double bouns = Math.Truncate(bounsamonut * bounsno * 1000) / 1000;

                double BasicSalary = double.Parse(degreeamounts.ToString()) + bouns;
                txtBasicSalary.Text = BasicSalary.ToString();

                double wg = BasicSalary / 30;
                double wage = Math.Truncate(wg * 1000) / 1000;
                txtWage.Text = wage.ToString();


                double amountt;
                if (double.TryParse(txtAbsentDay.Text, out amountt))
                {
                    AbsentDay += amountt;
                }

                double absentamount = wage * amountt;
                txtabsentamount.Text = absentamount.ToString();

                double allowanceSecondment = BasicSalary * 0.1;
                txtallowanceSecondment.Text = allowanceSecondment.ToString();

                double amount;

                if (double.TryParse(txtallowanceDelay.Text, out amount))
                {
                    allowanceDelay += amount;
                }

                double committeamount;
                if (double.TryParse(txtcommittee.Text, out committeamount))
                {
                    committee += committeamount;
                }

                double exempttax;
                if (double.TryParse(txtexempttax.Text, out exempttax))
                {
                    exempt += exempttax;
                }

                double insurancetax;
                if (double.TryParse(txtinsurancetax.Text, out insurancetax))
                {
                    insurance += insurancetax;
                }

                double unempGift;
                if (double.TryParse(txtunempGift.Text, out unempGift))
                {
                    unempGiftt += unempGift;
                }

                double othergift;
                if (double.TryParse(txtothergift.Text, out othergift))
                {
                    othergiftt += othergift;
                }

                double allowancediff;
                if (double.TryParse(txtallowancediff.Text, out allowancediff))
                {
                    allowancedifference += allowancediff;
                }

                double pastyears;
                if (double.TryParse(txtpastyears.Text, out pastyears))
                {
                    pastyearss += pastyears;
                }

                double loandiscount;
                if (double.TryParse(txtloandiscount.Text, out loandiscount))
                {
                    loandiscountt += loandiscount;
                }

                double paycaruse;
                if (double.TryParse(txtpaycaruse.Text, out paycaruse))
                {
                    paycaruses += paycaruse;
                }

                double addsecond;
                if (double.TryParse(txtaddSecond.Text, out addsecond))
                {
                    addsecondd += addsecond;
                }

                double houseloan;
                if (double.TryParse(txthouseloan.Text, out houseloan))
                {
                    houseloans += houseloan;
                }

                double TotalAllowanace =  amount + committeamount + othergift + unempGift + addsecond + allowancediff + pastyears;
                txtTotalAllowanace.Text = TotalAllowanace.ToString();

                double TotalSalary = BasicSalary + amount + committeamount + othergift + unempGift + addsecond + allowancediff + pastyears;
                txtTotalSalary.Text = TotalSalary.ToString();


                txtsancted.Text = txtabsentamount.Text;

                double SocialSecurityTax = Math.Truncate(TotalSalary * 37.5) / 1000;
                txtSocialSecurityTax.Text = SocialSecurityTax.ToString();

                double solidarityTax = Math.Truncate(TotalSalary * 10) / 1000;
                txtsolidarityTax.Text = solidarityTax.ToString();

                double jd = TotalSalary - (SocialSecurityTax + solidarityTax);
                double JihadTax = Math.Truncate(jd * 30) / 1000;
                txtJihadTax.Text = JihadTax.ToString();

                double salarysalaryWorkContribution = Math.Truncate(TotalSalary * 105) / 1000;
                txtsalarysalaryWorkContribution.Text = salarysalaryWorkContribution.ToString();

                double salaryTreasurContribution = Math.Truncate(TotalSalary * 7.5) / 1000;
                txtsalaryTreasurContribution.Text = salaryTreasurContribution.ToString();

                double tas = SocialSecurityTax + salarysalaryWorkContribution + salaryTreasurContribution;
                txttotalsocailtax.Text = tas.ToString();

                double taj = TotalSalary - (SocialSecurityTax + solidarityTax);
                txtamountjihad.Text = taj.ToString();

                double serviceboxtax = Math.Truncate(BasicSalary * 15) / 1000;
                txtservicebox.Text = serviceboxtax.ToString();

                double incometax = TotalSalary - SocialSecurityTax - solidarityTax - exempttax;
                txtincometax.Text = incometax.ToString();

                double incomeTaxed = double.Parse(txtincometax.Text.ToString());
                if (incomeTaxed <= 1000)
                {
                    txtincome5tax.Text = Math.Truncate((incomeTaxed * 50) / 1000).ToString();
                    txtincome10tax.Text = "0";
                }
                else
                {
                    double afterThousend;
                    afterThousend = incomeTaxed - 1000;
                    txtincome5tax.Text = (50).ToString();
                    txtincome10tax.Text = Math.Truncate((afterThousend * 100) / 1000).ToString();
                }


                txttotalincometax.Text = (double.Parse(txtincome5tax.Text) + double.Parse(txtincome10tax.Text)).ToString();

                double TotalTaxes = SocialSecurityTax + solidarityTax + JihadTax + serviceboxtax + insurancetax + loandiscount + houseloan + double.Parse(txttotalincometax.Text) + double.Parse(txtsancted.Text);
                txtTotalTaxes.Text = TotalTaxes.ToString();

                double NetSalary = TotalSalary - TotalTaxes + paycaruse;
                txtNetSalary.Text = NetSalary.ToString();
            }
            else
            {
                txtallowanceSecondment.Visible = false;
                txtaddSecond.Visible = false;

                double bounsamonut = double.Parse(bounsamounts.ToString());

                double bounsno = double.Parse(bounss.ToString());

                double bouns = Math.Truncate(bounsamonut*bounsno*1000)/1000;

                double BasicSalary = double.Parse(degreeamounts.ToString()) + bouns;
                txtBasicSalary.Text = BasicSalary.ToString();

 
                double wage = Math.Truncate((BasicSalary/30) * 1000)/1000;
                txtWage.Text = wage.ToString();

                double allowanceSecondment = BasicSalary * 0.0;
                txtallowanceSecondment.Text = allowanceSecondment.ToString();

                double amountt;
                if (double.TryParse(txtAbsentDay.Text, out amountt))
                {
                    AbsentDay += amountt;
                }

                double absentamount = wage * amountt;
                txtabsentamount.Text = absentamount.ToString();

                double amount;

                if (double.TryParse(txtallowanceDelay.Text, out amount))
                {
                    allowanceDelay += amount;
                }

                double committeamount;
                if (double.TryParse(txtcommittee.Text, out committeamount))
                {
                    committee += committeamount;
                }

                double exempttax;
                if (double.TryParse(txtexempttax.Text, out exempttax))
                {
                    exempt += exempttax;
                }

                double insurancetax;
                if (double.TryParse(txtinsurancetax.Text, out insurancetax))
                {
                    insurance += insurancetax;
                }


                double sanctiontax;
                if (double.TryParse(txtsancted.Text, out sanctiontax))
                {
                    sancted += sanctiontax;
                }

                double unempGift;
                if (double.TryParse(txtunempGift.Text, out unempGift))
                {
                    unempGiftt += unempGift;
                }

                double othergift;
                if (double.TryParse(txtothergift.Text, out othergift))
                {
                    othergiftt += othergift;
                }

                double allowancediff;
                if (double.TryParse(txtallowancediff.Text, out allowancediff))
                {
                    allowancedifference += allowancediff;
                }

                double pastyears;
                if (double.TryParse(txtpastyears.Text, out pastyears))
                {
                    pastyearss += pastyears;
                }

                double loandiscount;
                if (double.TryParse(txtloandiscount.Text, out loandiscount))
                {
                    loandiscountt += loandiscount;
                }


                double paycaruse;
                if (double.TryParse(txtpaycaruse.Text, out paycaruse))
                {
                    paycaruses += paycaruse;
                }

                double houseloan;
                if (double.TryParse(txthouseloan.Text, out houseloan))
                {
                    houseloans += houseloan;
                }


                double TotalAllowanace = amount + committeamount + othergift + unempGift + allowancediff + pastyears;
                txtTotalAllowanace.Text = TotalAllowanace.ToString();

                double TotalSalary = BasicSalary + amount + committeamount + othergift + unempGift + allowancediff + pastyears;
                txtTotalSalary.Text = TotalSalary.ToString();

                txtsancted.Text = txtabsentamount.Text;

                double SocialSecurityTax = Math.Truncate(TotalSalary * 37.5)/1000;
                txtSocialSecurityTax.Text = SocialSecurityTax.ToString();

                double solidarityTax = Math.Truncate(TotalSalary * 10)/1000;
                txtsolidarityTax.Text = solidarityTax.ToString();

                double jd = TotalSalary - (SocialSecurityTax + solidarityTax);
                double JihadTax = Math.Truncate(jd * 30)/1000;
                txtJihadTax.Text = JihadTax.ToString();

                double salarysalaryWorkContribution = Math.Truncate(TotalSalary * 105)/1000;
                txtsalarysalaryWorkContribution.Text = salarysalaryWorkContribution.ToString();

                double salaryTreasurContribution = Math.Truncate(TotalSalary * 7.5)/1000;
                txtsalaryTreasurContribution.Text = salaryTreasurContribution.ToString();

                double totalamountsocial = SocialSecurityTax + salarysalaryWorkContribution + salaryTreasurContribution;
                txttotalsocailtax.Text = totalamountsocial.ToString();

                double totalamountjihad = TotalSalary - (SocialSecurityTax + solidarityTax);
                txtamountjihad.Text = totalamountjihad.ToString();

                double serviceboxtax = Math.Truncate(BasicSalary * 0.015*1000)/1000;
                txtservicebox.Text = serviceboxtax.ToString();

                double incometax = TotalSalary - SocialSecurityTax - solidarityTax - exempttax;
                txtincometax.Text = incometax.ToString();

                double incomeTaxed = double.Parse(txtincometax.Text.ToString());
                if (incomeTaxed <= 1000)
                {
                    txtincome5tax.Text = Math.Truncate((incomeTaxed * 50) / 1000).ToString();
                    txtincome10tax.Text = "0";
                }
                else
                {
                    double afterThousend;
                    afterThousend = incomeTaxed - 1000;
                    txtincome5tax.Text = (50).ToString();
                    txtincome10tax.Text = Math.Truncate((afterThousend * 100) / 1000).ToString();
                }

                txttotalincometax.Text = (double.Parse(txtincome5tax.Text) + double.Parse(txtincome10tax.Text)).ToString();

                double TotalTaxes = SocialSecurityTax + solidarityTax + JihadTax + serviceboxtax + insurancetax + loandiscount + houseloan + double.Parse(txttotalincometax.Text) + double.Parse(txtsancted.Text) ;
                txtTotalTaxes.Text = TotalTaxes.ToString();

                double NetSalary = (TotalSalary - TotalTaxes)+paycaruse;
                txtNetSalary.Text = NetSalary.ToString();
            }
        }

        private void cbemployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbannualBounsId.SelectedItem = cbemployeeId.SelectedItem;
            cbBouns.SelectedItem = cbemployeeId.SelectedItem;
            cbdegreeamount.SelectedItem = cbemployeeId.SelectedItem;
            cbdegree.SelectedItem = cbemployeeId.SelectedItem;
            cbemploymentType.SelectedItem = cbemployeeId.SelectedItem;
        }

        private void txtallowanceDelay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcommittee_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtAbsentDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtallowanceDelay_Click(object sender, EventArgs e)
        {
        }

        private void txtrmonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrmonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txtrmonth.Text + e.KeyChar) >= 13 ||
                txtrmonth.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (txtyear.Text.IndexOf(' ') == txtyear.Text.Length - 5)
                e.Handled = true;
        }

        private void txtpaycaruse_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AddSalary_Load(object sender, EventArgs e)
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Libya));
        }

        private void txtNetSalary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(txtNetSalary.Text), currencies[Convert.ToInt32(cboCurrency.SelectedValue)]);
                txtArabicWord.Text = toWord.ConvertToArabic();
                txtArabicWord.Text = txtArabicWord.Text.Substring(0, txtArabicWord.Text.IndexOf("دينار") + 5);
                decimal d = Convert.ToDecimal(txtNetSalary.Text) - Math.Truncate(Convert.ToDecimal(txtNetSalary.Text));
                if (d > 0)
                    txtArabicWord.Text += " و " + d.ToString().Substring(d.ToString().IndexOf('.') + 1, 3) + " درهما لاغير";
            }
            catch (Exception ex)
            {
                txtArabicWord.Text = String.Empty;
            }
        }

        private void txtsancted_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArabicWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtservicebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
