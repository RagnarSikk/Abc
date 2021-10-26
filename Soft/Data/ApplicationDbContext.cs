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

        public DbSet<Abc.Data.AdminstratorData> AdminstratorData { get; set; }

        public DbSet<Abc.Data.AthleteData> AthleteData { get; set; }

        public DbSet<Abc.Data.CoachData> CoachData { get; set; }

        public DbSet<Abc.Data.EquipmentData> EquipmentData { get; set; }

        public DbSet<Abc.Data.NutritionistData> NutritionistData { get; set; }

        public DbSet<Abc.Data.PhysiotherapistData> PhysiotherapistData { get; set; }

        public DbSet<Abc.Data.TherapistData> TherapistData { get; set; }
    }
}
