using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others {
    [TestClass]
    public class EquipmentRepositoryTests : RepoTests<EquipmentRepository, Equipment, EquipmentData> {
        protected override object createObject()
            => new EquipmentRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override Equipment toObject(EquipmentData d) => new(d);
    }
}
