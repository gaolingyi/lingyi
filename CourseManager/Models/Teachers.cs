namespace CourseManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Teachers
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        public string Nmae { get; internal set; }
    }
}
