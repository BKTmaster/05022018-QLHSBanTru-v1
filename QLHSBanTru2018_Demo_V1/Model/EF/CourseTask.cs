namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourseTask")]
    public partial class CourseTask
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        public double PhysicalRating { get; set; }

        public double StudyRating { get; set; }

        public double TotalRating { get; set; }

        public bool Passes { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public bool Status { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
