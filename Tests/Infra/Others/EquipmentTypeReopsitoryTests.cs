using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others {
    [TestClass]
    public class EquipmentTypeRepositoryTests : RepoTests<EquipmentTypeRepository, EquipmentType, EquipmentTypeData>
    {
        protected override object createObject()
            => new EquipmentTypeRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override EquipmentType toObject(EquipmentTypeData d) => new(d);
    }
}
