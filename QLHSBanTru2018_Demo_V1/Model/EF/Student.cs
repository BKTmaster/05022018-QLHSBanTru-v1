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
        public int ID { get; set; }

        [StringLength(10)]
        public string StudentCode { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string HomeName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public bool? Gender { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [StringLength(50)]
        public string Hobby { get; set; }

        [StringLength(50)]
        public string Talent { get; set; }

        public int? EthnicGroupID { get; set; }

        public int? ReligionID { get; set; }

        public int? BirthPlaceID { get; set; }

        public int? AdressID { get; set; }

        [StringLength(100)]
        public string AdressDetail { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public bool? Status { get; set; }
    }
}
