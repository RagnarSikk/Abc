using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories {
    [TestClass]
    public class EquipmentTypeViewFactoryTests : FactoryBaseTests<EquipmentTypeViewFactory, EquipmentTypeData, EquipmentType, EquipmentTypeView> {
        protected override EquipmentType createObject(EquipmentTypeData d) => new(d);
    }
}
