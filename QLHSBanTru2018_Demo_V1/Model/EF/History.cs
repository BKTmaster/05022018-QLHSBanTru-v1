namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History")]
    public partial class History
    {
        public int HistoryID { get; set; }

        public int? EmployeeID { get; set; }

        public int? FunctionID { get; set; }

        public DateTime? HistoryTime { get; set; }

        [StringLength(100)]
        public string Detail { get; set; }

        public bool? Status { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Function Function { get; set; }
    }
}
