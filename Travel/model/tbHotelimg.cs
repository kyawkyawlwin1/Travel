namespace Travel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbHotelimg")]
    public partial class tbHotelimg
    {
        [Key]
        [StringLength(36)]
        public string Hotel_Image_ID { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] image { get; set; }

        [Required]
        [StringLength(36)]
        public string Visit_Place_ID { get; set; }
    }
}
