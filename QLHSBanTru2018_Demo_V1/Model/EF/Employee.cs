namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(32)]
        public string Password { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public bool? Gender { get; set; }

        [StringLength(20)]
        public string EthnicGroup { get; set; }

        [StringLength(20)]
        public string Religion { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(15)]
        public string IdentityNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfIssue { get; set; }

        [StringLength(50)]
        public string PlaceOfIssue { get; set; }

        public bool? Status { get; set; }
    }
}
