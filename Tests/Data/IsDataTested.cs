using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data {
    [TestClass] public class IsDomainTested : AssemblyTests {
        protected override string assembly => "Abc.Domain";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsShopTested()
            => isAllTested(assembly, nameSpace("Shop"));
    }
}
