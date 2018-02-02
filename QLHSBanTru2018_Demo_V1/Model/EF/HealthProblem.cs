namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HealthProblem")]
    public partial class HealthProblem
    {
        public int ID { get; set; }

        public int? StudentID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(100)]
        public string Signal { get; set; }

        [StringLength(100)]
        public string Diagnosed { get; set; }

        [StringLength(100)]
        public string Measure { get; set; }

        public int? Serverity { get; set; }

        public int? EmployeeID { get; set; }

        public bool? Status { get; set; }
    }
}
