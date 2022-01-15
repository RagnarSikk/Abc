using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class EquipmentDataTests : SealedTests<UniqueEntityData> {
        [TestMethod]
        public void PersonRoleTypeIdTest() => isProperty<string>(false);
        [TestMethod]
        public void EquipmentTypeIdTest() => isProperty<string>(false);
    }
}
