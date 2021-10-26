using Abc.Infra;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Abc.Data;

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
    }
}
