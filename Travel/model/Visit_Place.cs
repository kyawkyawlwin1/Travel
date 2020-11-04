namespace Travel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Visit_Place
    {
        [Key]
        [StringLength(36)]
        public string Visit_Place_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Visit_Place_Name { get; set; }

        [Required]
        public string Visit_Place_Desc { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
    }
}
