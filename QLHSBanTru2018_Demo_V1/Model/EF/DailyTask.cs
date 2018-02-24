namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailyTask")]
    public partial class DailyTask
    {
        public int DailyTaskID { get; set; }

<<<<<<< HEAD
        public int StudentID { get; set; }

        public int WeeklyTaskID { get; set; }
=======
        public int? StudentID { get; set; }
        //BBBB
        public int? WeeklyTaskID { get; set; }
>>>>>>> 9a1d953195b443c7ca37cc87e7ec79bfb2b086dd

        public int MonthlyTaskID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateTask { get; set; }

        public bool Present { get; set; }

        [Required]
        [StringLength(200)]
        public string Reason { get; set; }

        public TimeSpan DrugTime { get; set; }

        public double EatRating { get; set; }

        public double SleepRating { get; set; }

        public double HealthRating { get; set; }

        public double StudyRating { get; set; }

        public TimeSpan PickTime { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public bool Status { get; set; }

        public virtual PhysicalMonthlyTask PhysicalMonthlyTask { get; set; }

        public virtual Student Student { get; set; }

        public virtual WeeklyTask WeeklyTask { get; set; }
    }
}
