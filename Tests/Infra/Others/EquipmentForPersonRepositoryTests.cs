using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others {
    [TestClass]
    public class EquipmentForPersonRepositoryTests : RepoTests<EquipmentForPersonRepository, EquipmentForPerson, EquipmentForPersonData> {
        protected override object createObject()
            => new EquipmentForPersonRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override EquipmentForPerson toObject(EquipmentForPersonData d) => new(d);
    }
}
