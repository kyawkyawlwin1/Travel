namespace Travel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehicle")]
    public partial class Vehicle
    {
        [Key]
        [StringLength(36)]
        public string Vehicle_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Vehicle_Name { get; set; }

        [Required]
        public string Vehicle_Desc { get; set; }

        [Required]
        [StringLength(36)]
        public string Visit_Place_ID { get; set; }
    }
}
