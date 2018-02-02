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
        public int ID { get; set; }

        public int? GradeID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool? Status { get; set; }
    }
}
