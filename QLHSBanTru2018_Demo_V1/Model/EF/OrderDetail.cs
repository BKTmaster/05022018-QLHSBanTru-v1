namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IngredientID { get; set; }

        public decimal PriceOfUnit { get; set; }

        public int QuantityOfUnit { get; set; }

        public decimal TotalPrice { get; set; }

        public byte Discount { get; set; }

        public bool Status { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        public virtual Order Order { get; set; }
    }
}
