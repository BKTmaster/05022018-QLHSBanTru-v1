namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Class
    {
        public int ID { get; set; }

        public int? EmployeeID { get; set; }

        public int? ClassID { get; set; }

        public bool? Status { get; set; }
    }
}
