namespace ONLINE_Dr_APPOINTMENT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        [Key]
        public int Appointment_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Doctor_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone_No { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public DateTime Appointment_Date { get; set; }

        public DateTime Booking_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public int Schedule_fid { get; set; }

        public virtual Doctor_schedule Doctor_schedule { get; set; }
    }
}
