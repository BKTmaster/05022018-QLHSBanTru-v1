namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ingredient")]
    public partial class Ingredient
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? TypeID { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        public double? QuantityOfUnit { get; set; }

        public decimal? PriceOfUnit { get; set; }

        public double? Kalo { get; set; }

        public double? Protein { get; set; }

        public double? Fat { get; set; }

        public double? Glucose { get; set; }

        public double? Fiber { get; set; }

        public double? Canxi { get; set; }

        public double? Iron { get; set; }

        public double? Photpho { get; set; }

        public double? Kali { get; set; }

        public double? Natri { get; set; }

        public double? VitaminA { get; set; }

        public double? VitaminB1 { get; set; }

        public double? VitaminC { get; set; }

        public double? AxitFolic { get; set; }

        public double? Cholesterol { get; set; }

        public bool? Status { get; set; }
    }
}
