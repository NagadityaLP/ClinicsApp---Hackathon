using Entities;
using System.Data.Entity;
namespace DataAccessLayer
{
    public class ClinicDBContext : DbContext
    {
        public ClinicDBContext() : base("name=DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<ServiceClinicMapper>().HasKey(table => new { table.ServiceId, table.ClinicId });
        }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<ServiceClinicMapper> ServiceClinicMapper { get; set; }
    }
}
