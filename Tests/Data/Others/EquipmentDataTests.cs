using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class EquipmentDataTests : SealedTests<UniqueEntityData> {
        [TestMethod]
        public void AmountAvailableTest() => isProperty<int>(false);
        [TestMethod]
        public void AmountInUsingTest() => isProperty<int>(false);
    }
}
