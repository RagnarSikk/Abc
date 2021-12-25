using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class EquipmentForPersonDataTests : SealedTests<UniqueEntityData>
    {
        [TestMethod]
        public void PersonIdTest() => isProperty<string>(false);

        public void EquipmentIdTest() => isProperty<string>(false);
    }
}
