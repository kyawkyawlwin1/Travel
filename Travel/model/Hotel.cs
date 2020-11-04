namespace Travel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hotel")]
    public partial class Hotel
    {
        [Key]
        [StringLength(36)]
        public string Hotel_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Hotel_Name { get; set; }

        [Required]
        public string Hotel_Desc { get; set; }

        [Required]
        [StringLength(36)]
        public string Visit_Place_ID { get; set; }
    }
}
