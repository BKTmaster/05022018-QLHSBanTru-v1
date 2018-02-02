namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topic")]
    public partial class Topic
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int? TopicTypeID { get; set; }

        public bool? Status { get; set; }
    }
}
