using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class EquipmentTests : SealedTests<DefinedEntity<EquipmentData>> {
        private EquipmentData data;
        protected override object createObject() => new Equipment(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<EquipmentData>();
            base.TestInitialize();
        }
        [TestMethod] public void AmountAvailableTest() => isProperty(data.AmountAvailable);
        [TestMethod] public void AmountInUsingTest() => isProperty(data.AmountInUsing);
    }
}
