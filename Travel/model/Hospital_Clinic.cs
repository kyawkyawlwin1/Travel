namespace Travel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hospital_Clinic
    {
        [Key]
        [StringLength(36)]
        public string Hospital_Clinic_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Hospital_Clinic_Name { get; set; }

        [Required]
        public string Hospital_Clinic_Desc { get; set; }

        [Required]
        [StringLength(36)]
        public string Visit_Place_ID { get; set; }
    }
}
