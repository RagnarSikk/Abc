using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others
{
    [TestClass]
    public class EquipmentColourTests : RepoTests<EquipmentColourRepository, EquipmentColour, EquipmentColourData>
    {
        protected override object createObject()
            => new EquipmentColourRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override EquipmentColour toObject(EquipmentColourData d) => new(d);
    }
}