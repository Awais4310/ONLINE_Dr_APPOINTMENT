namespace ONLINE_Dr_APPOINTMENT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doctor_schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor_schedule()
        {
            Appointments = new HashSet<Appointment>();
        }

        [Key]
        public int Dr_schedule_id { get; set; }

        public int Doctor_fid { get; set; }

        [Required]
        [StringLength(50)]
        public string Dr_Schedule_Days { get; set; }

        public DateTime Start_Time { get; set; }

        public DateTime End_Time { get; set; }

        public int Total_Appointments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
