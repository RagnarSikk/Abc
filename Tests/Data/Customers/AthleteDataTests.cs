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
    public class AthleteDataTests : SealedTests<PersonData>{
        [TestMethod]
        public void WeightTest() => isProperty<double>(false);
        [TestMethod]
        public void HeightTest() => isProperty<double>(false);
        [TestMethod]
        public void AmountOfVisitsTest() => isProperty<int>(false);
    }
}
