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
    }
}
