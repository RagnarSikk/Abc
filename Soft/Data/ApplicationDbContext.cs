using Abc.Data.Customers;
using Abc.Data.Others;
using Abc.Data.People;
using Abc.Infra;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
        protected override void OnModelCreating(ModelBuilder b) {
            base.OnModelCreating(b);
            InitializeTables(b);
        }

        internal static void InitializeTables(ModelBuilder b) {
            TrainingDbContext.InitializeTables(b);
        }

        public DbSet<AdminstratorData> AdminstratorData { get; set; }

        public DbSet<AthleteData> AthleteData { get; set; }

        public DbSet<CoachData> CoachData { get; set; }

        public DbSet<EquipmentData> EquipmentData { get; set; }

        public DbSet<NutritionistData> NutritionistData { get; set; }

        public DbSet<PhysiotherapistData> PhysiotherapistData { get; set; }

        public DbSet<TherapistData> TherapistData { get; set; }
    }
}
