using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories {

    [TestClass]
    public class EquipmentViewFactoryTests : FactoryBaseTests<EquipmentViewFactory, EquipmentData, Equipment, EquipmentView>
    {
        protected override Equipment createObject(EquipmentData d) => new(d);
    }
}
