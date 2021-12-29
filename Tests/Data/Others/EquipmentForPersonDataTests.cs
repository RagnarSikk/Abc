using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class EquipmentForPersonDataTests : SealedTests<UniqueEntityData> {
        [TestMethod]
        public void PersonIdTest() => isProperty<string>(false);

        public void EquipmentIdTest() => isProperty<string>(false);
    }
}
