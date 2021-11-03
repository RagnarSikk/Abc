using Abc.Data.Common;
using Abc.Data.Customers;
using Abc.Facade.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Tests.Data.Customers
{
    [TestClass]
    public class AthleteDataTests : SealedTests<AthleteData, PersonData>{
        [TestMethod]
        public void WeightTest() {
            Assert.Inconclusive();
            //ToDo: Test the Athelete weightdata property
        }
        [TestMethod]
        public void HeightTest() {
            Assert.Inconclusive();
            //ToDo: Test the Athelete property
        }
        [TestMethod]
        public void AmountOfVisitsTest() {
            Assert.Inconclusive();
            //ToDo: Test the Athelete property
        }
    }
}
