namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailyMenu")]
    public partial class DailyMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DailyMenu()
        {
            DailyMenuDetails = new HashSet<DailyMenuDetail>();
        }

        public int DailyMenuID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int WeeklyMenuID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public bool IsForm { get; set; }

        public bool Status { get; set; }

        public virtual WeeklyMenu WeeklyMenu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailyMenuDetail> DailyMenuDetails { get; set; }
    }
}