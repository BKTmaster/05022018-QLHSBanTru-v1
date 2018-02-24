namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StudentParent
    {
        [Key]
        public int StudentParentsID { get; set; }

        public int StudentID { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        [Required]
        [StringLength(40)]
        public string FatherName { get; set; }

        [Column(TypeName = "date")]
        public DateTime FatherBirthday { get; set; }

        [Required]
        [StringLength(15)]
        public string FatherPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string FatherJob { get; set; }

        [Required]
        [StringLength(40)]
        public string MotherName { get; set; }

        [Column(TypeName = "date")]
        public DateTime MotherBirthday { get; set; }

        [Required]
        [StringLength(15)]
        public string MotherPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string MotherJob { get; set; }

        public virtual Student Student { get; set; }
    }
}
