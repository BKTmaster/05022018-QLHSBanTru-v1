namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HealthExaminationDetail")]
    public partial class HealthExaminationDetail
    {
        public int ID { get; set; }

        public int? TimeID { get; set; }

        public int? StudentID { get; set; }

        public int? HealthInsurance { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        [StringLength(30)]
        public string Eyes { get; set; }

        [StringLength(30)]
        public string ENT { get; set; }

        [StringLength(30)]
        public string InternalMedicine { get; set; }

        [StringLength(30)]
        public string Oral { get; set; }

        [StringLength(30)]
        public string Surgery { get; set; }

        [StringLength(30)]
        public string Dermatology { get; set; }

        [StringLength(30)]
        public string BoneMuscle { get; set; }

        [StringLength(30)]
        public string Nerve { get; set; }

        [StringLength(30)]
        public string Endocrine { get; set; }

        [StringLength(200)]
        public string Other { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public double? Rating { get; set; }

        public bool? Status { get; set; }
    }
}
