namespace ONLINE_Dr_APPOINTMENT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int Admin_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Admin_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Admin_Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Admin_Password { get; set; }

        [StringLength(50)]
        public string Admin_Gender { get; set; }
    }
}
