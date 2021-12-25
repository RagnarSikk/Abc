using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others
{
    [TestClass]
    class EquipmentTypeDataTests : SealedTests<DefinedEntityData>
    { [TestMethod]
        public void AmountAvailableTest() => isProperty<int>(false);
    }
}
