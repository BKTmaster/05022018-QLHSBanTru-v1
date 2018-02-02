namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string ContractType { get; set; }

        public int? EmployeeID { get; set; }

        public int? DepartmentID { get; set; }

        public int? PositionID { get; set; }

        public int? DegreeID { get; set; }

        public double? PayRate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }
    }
}