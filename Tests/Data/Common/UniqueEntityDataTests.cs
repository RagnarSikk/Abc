using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Common {
    [TestClass]
    public class UniqueEntityDataTests : AbstractTests<PeriodData> {
        private class testClass : UniqueEntityData { }
        protected override UniqueEntityData createObject() => new testClass();
        [TestMethod] public void IdTest() => isProperty<string>();
    }

}
