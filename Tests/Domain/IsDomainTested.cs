using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain
{
    [TestClass] public class IsDomainTested : AssemblyTests {
        protected override string assembly => "Abc.Data";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsShopTested()
            => isAllTested(assembly, nameSpace("Shop"));
    }
}
