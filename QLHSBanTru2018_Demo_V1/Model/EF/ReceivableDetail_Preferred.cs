namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReceivableDetail_Preferred
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceivableDetailID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PreferredID { get; set; }

        public double Percent { get; set; }

        public bool Status { get; set; }

        public virtual Preferred Preferred { get; set; }

        public virtual ReceivableDetail ReceivableDetail { get; set; }
    }
}
