namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailyMenu")]
    public partial class DailyMenu
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? WeeklyMenuID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public bool? IsForm { get; set; }

        public bool? Status { get; set; }
    }
}
