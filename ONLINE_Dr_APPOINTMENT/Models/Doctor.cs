namespace ONLINE_Dr_APPOINTMENT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            Doctor_schedule = new HashSet<Doctor_schedule>();
        }

        [Key]
        public int Doctor_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Doctor_Name { get; set; }

        public string Doctor_Picture { get; set; }

        [Required]
        [StringLength(250)]
        public string Doctor_Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Doctor_fees { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public int Specialization_fid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor_schedule> Doctor_schedule { get; set; }

        public virtual Specialization Specialization { get; set; }
    }
}
