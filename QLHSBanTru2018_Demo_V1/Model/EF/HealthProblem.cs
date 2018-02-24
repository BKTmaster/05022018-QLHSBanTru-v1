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
        public int HealthProblemID { get; set; }

        public int StudentID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Signal { get; set; }

        [Required]
        [StringLength(100)]
        public string Diagnosed { get; set; }

        [Required]
        [StringLength(100)]
        public string Measure { get; set; }

        public int Serverity { get; set; }

        public int EmployeeID { get; set; }

        public bool? Status { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Student Student { get; set; }
    }
}
