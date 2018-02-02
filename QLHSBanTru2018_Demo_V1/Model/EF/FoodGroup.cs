namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodGroup")]
    public partial class FoodGroup
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public double? MinKalo { get; set; }

        public double? MaxKalo { get; set; }

        public bool? Status { get; set; }
    }
}
