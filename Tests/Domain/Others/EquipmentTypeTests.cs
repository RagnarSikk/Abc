using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others
{
    [TestClass]
    public class EquipmentTypeTests : SealedTests<DefinedEntity<EquipmentTypeData>>
    {
        private EquipmentTypeData data;

        protected override object createObject() => new EquipmentType(data);
        [TestInitialize] public override void TestInitialize()
        {
            data = GetRandom.Object<EquipmentTypeData>();
            base.TestInitialize();
        }

        [TestMethod] public void AmountAvailableTest() => isProperty(data.AmountAvailable);
    }
}