namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            CourseTasks = new HashSet<CourseTask>();
            DailyTasks = new HashSet<DailyTask>();
            HealthExaminationDetails = new HashSet<HealthExaminationDetail>();
            HealthProblems = new HashSet<HealthProblem>();
            ReceivableDetail_Student = new HashSet<ReceivableDetail_Student>();
            Student_Class = new HashSet<Student_Class>();
            Student_Lesson = new HashSet<Student_Lesson>();
            StudentParents = new HashSet<StudentParent>();
        }

        public int StudentID { get; set; }

        [Required]
        [StringLength(10)]
        public string StudentCode { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string HomeName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        public bool Gender { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [StringLength(50)]
        public string Hobby { get; set; }

        [StringLength(50)]
        public string Talent { get; set; }

        public int EthnicGroupID { get; set; }

        public int ReligionID { get; set; }

        public int BirthPlaceID { get; set; }

        public int DistrictID { get; set; }

        [Required]
        [StringLength(100)]
        public string AdressDetail { get; set; }

        public int? PreferredID { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseTask> CourseTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailyTask> DailyTasks { get; set; }

        public virtual District District { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HealthExaminationDetail> HealthExaminationDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HealthProblem> HealthProblems { get; set; }

        public virtual Preferred Preferred { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceivableDetail_Student> ReceivableDetail_Student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Class> Student_Class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Lesson> Student_Lesson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentParent> StudentParents { get; set; }
    }
}
