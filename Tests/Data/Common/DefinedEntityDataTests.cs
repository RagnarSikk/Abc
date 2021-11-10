using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Common {
    [TestClass]
    public class DefinedEntityDataTests : AbstractTests<NamedEntityData> {
        private class testClass : DefinedEntityData { }
        protected override DefinedEntityData createObject() => new testClass();
        [TestMethod] public void DefinitionTest() => isProperty<string>();
    }

}
