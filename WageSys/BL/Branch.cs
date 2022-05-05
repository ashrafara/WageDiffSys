namespace WageSys
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Branch")]
    public partial class Branch
    {
        public int branchId { get; set; }

        public int? bankId { get; set; }
        
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string branchName { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
