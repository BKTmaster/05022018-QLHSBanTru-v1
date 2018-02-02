namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StudentParent
    {
        public int ID { get; set; }

        public int? StudentID { get; set; }

        [StringLength(32)]
        public string Password { get; set; }

        [StringLength(40)]
        public string FatherName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FatherBirthday { get; set; }

        [StringLength(15)]
        public string FatherPhone { get; set; }

        [StringLength(50)]
        public string FatherJob { get; set; }

        [StringLength(40)]
        public string MotherName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MotherBirthday { get; set; }

        [StringLength(15)]
        public string MotherPhone { get; set; }

        [StringLength(50)]
        public string MotherJob { get; set; }
    }
}
