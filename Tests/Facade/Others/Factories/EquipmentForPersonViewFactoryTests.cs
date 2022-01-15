using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories {
    [TestClass]
    public class EquipmentForPersonViewFactoryTests : FactoryBaseTests<EquipmentForPersonViewFactory, EquipmentForPersonData, EquipmentForPerson, EquipmentForPersonView>
    {
        protected override EquipmentForPerson createObject(EquipmentForPersonData d) => new(d);
    }
}
