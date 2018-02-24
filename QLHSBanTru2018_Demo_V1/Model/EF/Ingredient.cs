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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredient()
        {
            DishDetails = new HashSet<DishDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int IngredientID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int IngredientTypeID { get; set; }

        [Required]
        [StringLength(10)]
        public string Unit { get; set; }

        public double QuantityOfUnit { get; set; }

        public double Kcal { get; set; }

        public double Protein { get; set; }

        public double Fat { get; set; }

        public double Glucose { get; set; }

        public double Fiber { get; set; }

        public double Canxi { get; set; }

        public double Iron { get; set; }

        public double Photpho { get; set; }

        public double Kali { get; set; }

        public double Natri { get; set; }

        public double VitaminA { get; set; }

        public double VitaminB1 { get; set; }

        public double VitaminC { get; set; }

        public double AxitFolic { get; set; }

        public double Cholesterol { get; set; }

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DishDetail> DishDetails { get; set; }

        public virtual IngredientType IngredientType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
