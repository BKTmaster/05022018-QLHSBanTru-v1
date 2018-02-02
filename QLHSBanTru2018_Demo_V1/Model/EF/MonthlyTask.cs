namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonthlyTask")]
    public partial class MonthlyTask
    {
        public int ID { get; set; }

        public int? StudentID { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        [StringLength(100)]
        public string HeightRating { get; set; }

        [StringLength(100)]
        public string WeightRating { get; set; }

        public bool? Status { get; set; }
    }
}
