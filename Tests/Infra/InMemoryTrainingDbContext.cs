using Abc.Infra;
using Microsoft.EntityFrameworkCore;

namespace Abc.Tests.Infra {
    internal class InMemoryTrainingDbContext {
        public TrainingDbContext TrainingDb;
        public InMemoryTrainingDbContext() {
            var options = new DbContextOptionsBuilder<TrainingDbContext>().UseInMemoryDatabase("TestDb").Options;
            TrainingDb = new TrainingDbContext(options);
        }
    }
}
