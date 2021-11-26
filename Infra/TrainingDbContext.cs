using Abc.Data.Others;
using Abc.Data.People;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra {
    public class TrainingDbContext : DbContext {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options)
            : base(options) { }
        public DbSet<EquipmentData> Equipments { get; set; }
        public DbSet<TrainingData> Trainings { get; set; }
        public DbSet<ServiceData> Services { get; set; }
        public DbSet<ServiceTypeData> ServiceTypes { get; set; }
        public DbSet<PersonData> Persons { get; set; }
        public DbSet<PersonRoleData> PersonRoles { get; set; }
        public DbSet<PersonRoleTypeData> PersonRoleTypes { get; set; }
        public DbSet<BodyMetricData> BodyMetrics { get; set; }

        protected override void OnModelCreating(ModelBuilder b) {
            base.OnModelCreating(b);
            InitializeTables(b);
        }
        public static void InitializeTables(ModelBuilder b) {
            b.Entity<EquipmentData>().ToTable(nameof(Equipments));
            b.Entity<TrainingData>().ToTable(nameof(Trainings));
            b.Entity<ServiceData>().ToTable(nameof(Services));
            b.Entity<ServiceTypeData>().ToTable(nameof(ServiceTypes));
            b.Entity<PersonData>().ToTable(nameof(Persons));
            b.Entity<PersonRoleData>().ToTable(nameof(PersonRoles));
            b.Entity<PersonRoleTypeData>().ToTable(nameof(PersonRoleTypes));
            b.Entity<BodyMetricData>().ToTable(nameof(BodyMetrics));
        }
    }
}
