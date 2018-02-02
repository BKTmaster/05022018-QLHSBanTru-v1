namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Class
    {
        public int ID { get; set; }

        public int? StudentID { get; set; }

        public int? ClassID { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public bool? Status { get; set; }
    }
}
