using Abc.Data.Common;
using Abc.Data.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Customers {
    [TestClass]
    public class AthleteDataTests : SealedTests<PersonData> {
        [TestMethod]
        public void WeightTest() => isProperty<double>(false);
        [TestMethod]
        public void HeightTest() => isProperty<double>(false);
        [TestMethod]
        public void AmountOfVisitsTest() => isProperty<int>(false);
    }
}
