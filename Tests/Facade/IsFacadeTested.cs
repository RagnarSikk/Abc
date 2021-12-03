using Abc.Tests.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade
{
    [TestClass]
    public class IsFacadeTested : AssemblyTests
    {
        protected override string assembly => "Abc.Facade";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsPeopleTested()
            => isAllTested(assembly, nameSpace("People"));

        [TestMethod]
        public void IsOthersTested()
            => isAllTested(assembly, nameSpace("Others"));
    }
}
