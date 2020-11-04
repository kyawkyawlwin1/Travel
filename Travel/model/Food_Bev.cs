namespace Travel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Food_Bev
    {
        [Key]
        [StringLength(36)]
        public string Food_Bev_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Food_Bev_Name { get; set; }

        [Required]
        public string Food_Bev_Desc { get; set; }

        [Required]
        [StringLength(36)]
        public string Visit_Place_ID { get; set; }
    }
}
