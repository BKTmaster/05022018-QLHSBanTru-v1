namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhysicalMonthlyTask")]
    public partial class PhysicalMonthlyTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhysicalMonthlyTask()
        {
            DailyTasks = new HashSet<DailyTask>();
        }

        public int PhysicalMonthlyTaskID { get; set; }

        public int StudentID { get; set; }

        [Required]
        [StringLength(200)]
        public string Note { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        [Required]
        [StringLength(100)]
        public string HeightRating { get; set; }

        [Required]
        [StringLength(100)]
        public string WeightRating { get; set; }

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailyTask> DailyTasks { get; set; }
    }
}
