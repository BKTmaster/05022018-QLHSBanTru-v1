namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceivableDetail")]
    public partial class ReceivableDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceivableDetail()
        {
            ReceivableDetail_Preferred = new HashSet<ReceivableDetail_Preferred>();
            ReceivableDetail_Student = new HashSet<ReceivableDetail_Student>();
        }

        public int ReceivableDetailID { get; set; }

        public int ReceivableID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal SalePrice { get; set; }

        public bool Status { get; set; }

        public virtual Receivable Receivable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceivableDetail_Preferred> ReceivableDetail_Preferred { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceivableDetail_Student> ReceivableDetail_Student { get; set; }
    }
}
