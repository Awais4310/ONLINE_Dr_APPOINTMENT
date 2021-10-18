namespace ONLINE_Dr_APPOINTMENT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hospital")]
    public partial class Hospital
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hospital()
        {
            Specializations = new HashSet<Specialization>();
        }

        [Key]
        public int Hospital_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Hospital_Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Hospital_Adress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specialization> Specializations { get; set; }
    }
}
