namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? Date { get; set; }

        public int? EmployeeID1 { get; set; }

        public int? EmployeeID2 { get; set; }

        public int? EmployeeID3 { get; set; }

        public bool? Status { get; set; }
    }
}
