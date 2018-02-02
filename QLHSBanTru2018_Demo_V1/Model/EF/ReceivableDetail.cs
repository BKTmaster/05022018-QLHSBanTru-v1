namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceivableDetail")]
    public partial class ReceivableDetail
    {
        public int ID { get; set; }

        public int? ReceivableID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public decimal? Proceeds { get; set; }

        public bool? Status { get; set; }
    }
}
