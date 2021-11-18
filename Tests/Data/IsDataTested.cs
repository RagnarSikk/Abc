using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data {
    [TestClass]
    public class IsDataTested : AssemblyTests {
        protected override string assembly => "Abc.Data";
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
