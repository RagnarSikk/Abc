using Abc.Aids.Random;
using Abc.Data.Common;
using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common
{
    public class TestData : DefinedEntityData { }

    [TestClass] public class DefinedEntityTests : AbstractTests<NamedEntity<TestData>> {
        private TestData data;

        private class testClass: DefinedEntity<TestData> { 
            public testClass(TestData d) : base(d) { }
        }
        protected override object createObject()
        {
            data = GetRandom.Object<TestData>();
            return new testClass(data);
        }
        [TestMethod] public void DefinitionTest() => isProperty(data.Definition);
    }
}
