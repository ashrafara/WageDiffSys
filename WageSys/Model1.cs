namespace WageSys
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeDegreee> EmployeeDegreees { get; set; }
        public virtual DbSet<SalaryLog> SalaryLogs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>()
                .HasMany(e => e.Branches)
                .WithOptional(e => e.Bank)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Bank>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Bank)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.SalaryLogs)
                .WithOptional(e => e.Employee)
                .WillCascadeOnDelete();

            modelBuilder.Entity<EmployeeDegreee>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.EmployeeDegreee)
                .WillCascadeOnDelete();

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.basicSalary)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.allowanceDelay)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.allowanceSecondment)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.totalSalary)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.socialSecutiyTax)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.solidarityTax)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.jihadTax)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.totalTax)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.TotalSalaryNet)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.TotalAllowanace)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.salaryWorkContribution)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.salaryTreasurContribution)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.salaryTotalContribution)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.salaryAbsentDay)
            //    //.HasPrecision(18, 3);

            //modelBuilder.Entity<SalaryLog>()
            //    .Property(e => e.committeeAmount)
            //    //.HasPrecision(18, 3);
        }
    }
}
