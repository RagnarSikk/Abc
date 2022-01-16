using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories {
    [TestClass]
    public class EquipmentColourViewFactoryTests : FactoryBaseTests<EquipmentColourViewFactory, EquipmentColourData, EquipmentColour, EquipmentColourView> {
        protected override EquipmentColour createObject(EquipmentColourData d) => new(d);


    }
}
