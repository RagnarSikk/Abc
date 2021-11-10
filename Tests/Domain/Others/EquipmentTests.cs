using Abc.Aids.Random;
using Abc.Data.Customers;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
