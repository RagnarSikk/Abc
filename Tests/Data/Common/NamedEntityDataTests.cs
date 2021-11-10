using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Common {
    [TestClass]
    public class NamedEntityDataTests : AbstractTests<UniqueEntityData> {
        private class testClass : NamedEntityData { }
        protected override NamedEntityData createObject() => new testClass();
        [TestMethod] public void NameTest() => isProperty<string>();
    }

}
