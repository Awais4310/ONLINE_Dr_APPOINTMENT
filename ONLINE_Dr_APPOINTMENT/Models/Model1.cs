using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ONLINE_Dr_APPOINTMENT.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Doctor_schedule> Doctor_schedule { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Doctor_schedule)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.Doctor_fid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor_schedule>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Doctor_schedule)
                .HasForeignKey(e => e.Schedule_fid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hospital>()
                .HasMany(e => e.Specializations)
                .WithOptional(e => e.Hospital)
                .HasForeignKey(e => e.Hospital_fid);

            modelBuilder.Entity<Specialization>()
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.Specialization)
                .HasForeignKey(e => e.Specialization_fid)
                .WillCascadeOnDelete(false);
        }
    }
}
