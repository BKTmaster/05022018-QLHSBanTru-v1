namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailyMenuDetail")]
    public partial class DailyMenuDetail
    {
        public int ID { get; set; }

        public int? DailyMenuID { get; set; }

        public int? MealID { get; set; }

        public int? DishID { get; set; }

        public bool? Status { get; set; }
    }
}
