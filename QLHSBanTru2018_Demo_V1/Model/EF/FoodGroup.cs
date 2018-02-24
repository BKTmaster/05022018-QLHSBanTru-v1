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
        public int FoodGroupID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public double MinKcal { get; set; }

        public double MaxKcal { get; set; }

        public bool Status { get; set; }
    }
}
