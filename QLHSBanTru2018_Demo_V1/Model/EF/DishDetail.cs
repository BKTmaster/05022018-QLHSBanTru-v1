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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DishDetailID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DishID { get; set; }

        public int IngredientID { get; set; }

        public double QuantiyOfUnit { get; set; }

        public bool Status { get; set; }

        public virtual Dish Dish { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}
