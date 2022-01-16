using Abc.Aids.Random;
using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common {
    [TestClass]
    public class NamedEntityTests : AbstractTests<UniqueEntity<TestData>> {
        private TestData data;

        private class testClass : NamedEntity<TestData> {
            public testClass(TestData d) : base(d) { }
        }
        protected override object createObject() {
            data = GetRandom.Object<TestData>();
            return new testClass(data);
        }
        [TestMethod] public void NameTest() => isProperty(data.Name);
        [TestMethod] public void CodeTest() => isProperty(data.Code);
    }
}
