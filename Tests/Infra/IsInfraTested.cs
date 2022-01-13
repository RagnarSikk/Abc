using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra {
    [TestClass]
    public class IsInfraTested : AssemblyTests {
        protected override string assembly => "Abc.Infra";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsOtherTested()
            => isAllTested(assembly, nameSpace("Other"));
        [TestMethod]
        public void IsPeopleTested()
            => isAllTested(assembly, nameSpace("People"));
    }
}
