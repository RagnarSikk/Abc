using Abc.Data.Common;
using Abc.Data.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class EquipmentDataTests : SealedTests<DefinedEntityData> {
        [TestMethod]
        public void AmountAvailableTest() => isProperty<int>(false);
        [TestMethod]
        public void AmountInUsingTest() => isProperty<int>(false);
    }
}
