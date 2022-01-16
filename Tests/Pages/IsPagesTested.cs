using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages {
    [TestClass]
    public class IsPagesTested : AssemblyTests {
        protected override string assembly => "Abc.Pages";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsAidsTested()
            => isAllTested(assembly, nameSpace("Common.Aids"));
        [TestMethod]
        public void IsConstsTested()
            => isAllTested(assembly, nameSpace("Common.Consts"));
        [TestMethod]
        public void IsExtensionTested()
            => isAllTested(assembly, nameSpace("Common.Extensions"));
        [TestMethod]
        public void IsPeopleTested()
            => isAllTested(assembly, nameSpace("People"));
    }
}
