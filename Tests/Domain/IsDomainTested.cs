using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain {
    [TestClass]
    public class IsDomainTested : AssemblyTests {
        protected override string assembly => "Abc.Domain";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsCustomersTested()
            => isAllTested(assembly, nameSpace("Customers"));
        [TestMethod]
        public void IsOthersTested()
            => isAllTested(assembly, nameSpace("Others"));
        [TestMethod]
        public void IsPeopleTested()
            => isAllTested(assembly, nameSpace("People"));
    }
}
