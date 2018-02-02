namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HealthExamination")]
    public partial class HealthExamination
    {
        public int ID { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Place { get; set; }

        public bool? Height { get; set; }

        public bool? Weight { get; set; }

        public bool? Eyes { get; set; }

        public bool? ENT { get; set; }

        public bool? InternalMedicine { get; set; }

        public bool? Oral { get; set; }

        public bool? Surgery { get; set; }

        public bool? Dermatology { get; set; }

        public bool? BoneMuscle { get; set; }

        public bool? Nerve { get; set; }

        public bool? Endocrine { get; set; }

        public bool? Status { get; set; }
    }
}
