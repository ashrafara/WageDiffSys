namespace WageSys
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeDegreee")]
    public partial class EmployeeDegreee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeDegreee()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        public int degreeId { get; set; }

        [StringLength(50)]
        public string degreeNumber { get; set; }

        public double? degreeAmount { get; set; }

        public double? bounsNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
