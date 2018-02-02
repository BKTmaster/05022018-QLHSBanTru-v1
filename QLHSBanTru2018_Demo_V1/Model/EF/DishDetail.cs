namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DishDetail")]
    public partial class DishDetail
    {
        [Key]
        public int DishID { get; set; }

        public int? IngredientID { get; set; }

        public double? QuantiyOfUnit { get; set; }

        public bool? Status { get; set; }
    }
}
