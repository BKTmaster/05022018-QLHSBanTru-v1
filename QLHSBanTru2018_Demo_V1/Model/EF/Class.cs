namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class")]
    public partial class Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            Employee_Class = new HashSet<Employee_Class>();
            Student_Class = new HashSet<Student_Class>();
        }

<<<<<<< HEAD
        public int ClassID { get; set; }

        public int GradeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool Status { get; set; }

        public virtual Grade Grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Class> Employee_Class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Class> Student_Class { get; set; }
=======
        public int? GradeID { get; set; }
        //
        [StringLength(50)]
        public string Name { get; set; }
        //
        public bool? Status { get; set; }
>>>>>>> 9a1d953195b443c7ca37cc87e7ec79bfb2b086dd
    }
}
