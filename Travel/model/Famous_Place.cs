namespace Travel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Famous_Place
    {
        [Key]
        [StringLength(36)]
        public string Famous_Place_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Famous_Place_Name { get; set; }

        [Required]
        public string Famous_Place_Desc { get; set; }

        [Required]
        [StringLength(36)]
        public string Visit_Place_ID { get; set; }
    }
}
