namespace WageSys
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryLog")]
    public partial class SalaryLog
    {
        public int salaryLogID { get; set; }

        public int? employeeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? salaryDate { get; set; }

        public double? basicSalary { get; set; }

        public double? allowanceDelay { get; set; }

        public double? allowanceSecondment { get; set; }

        public double? totalSalary { get; set; }

        public double? socialSecutiyTax { get; set; }

        public double? solidarityTax { get; set; }

        public double? jihadTax { get; set; }

        public double? totalTax { get; set; }

        public double? TotalSalaryNet { get; set; }

        public double? TotalAllowanace { get; set; }

        public double? salaryWorkContribution { get; set; }

        public double? salaryTreasurContribution { get; set; }

        public double? salaryTotalContribution { get; set; }

        public double? salaryAbsentDay { get; set; }

        [StringLength(50)]
        public string salaryMonth { get; set; }

        [StringLength(50)]
        public string salarayyear { get; set; }

        public int? cheaqueNum { get; set; }

        public double? committeeAmount { get; set; }

        public double? totalamountsocial { get; set; }

        public double? totalamountjihad { get; set; }

        public double? serviceboxtax { get; set; }

        public double? exempttax { get; set; }

        public double? totalincometax { get; set; }

        public double? income5tax { get; set; }

        public double? income10tax { get; set; }

        public double? totalincome { get; set; }

        public double? insurancetax { get; set; }

        public double? sanctiontax { get; set; }

        public double? unempGift { get; set; }

        public double? othergift { get; set; }

        public double? allowancediff { get; set; }

        public double? pastyears { get; set; }

        public double? loandiscount { get; set; }

        public double? paycaruse { get; set; }

        public int? employeeDegree { get; set; }

        public int? employeeBouns { get; set; }

        public double? absentamount { get; set; }

        public double? addsecondement { get; set; }

        public double? houseloan { get; set; }

        [StringLength(250)]
        public string salaryletter { get; set; }

        [StringLength(50)]
        public string saltype { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
