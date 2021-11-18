using Abc.Data.Customers;
using Abc.Data.Others;
using Abc.Data.People;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra {
    public class TrainingDbContext : DbContext {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options)
            : base(options) { }
        public DbSet<AdministratorData> Administrators { get; set; }
        public DbSet<AthleteData> Athletes { get; set; }
        public DbSet<CoachData> Coaches { get; set; }
        public DbSet<NutritionistData> Nutritionists { get; set; }
        public DbSet<PhysiotherapistData> Physiotherapists { get; set; }
        public DbSet<TherapistData> Therapists { get; set; }
        public DbSet<EquipmentData> Equipments { get; set; }
        public DbSet<TrainingData> Trainings { get; set; }

        protected override void OnModelCreating(ModelBuilder b) {
            base.OnModelCreating(b);
            InitializeTables(b);
        }
        public static void InitializeTables(ModelBuilder b) {
            b.Entity<EquipmentData>().ToTable(nameof(Equipments));
            b.Entity<TherapistData>().ToTable(nameof(Therapists));
            b.Entity<PhysiotherapistData>().ToTable(nameof(Physiotherapists));
            b.Entity<NutritionistData>().ToTable(nameof(Nutritionists));
            b.Entity<CoachData>().ToTable(nameof(Coaches));
            b.Entity<AthleteData>().ToTable(nameof(Athletes));
            b.Entity<AdministratorData>().ToTable(nameof(Administrators));
            b.Entity<TrainingData>().ToTable(nameof(Trainings));
        }
    }
}
