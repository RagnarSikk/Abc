﻿using Abc.Aids.Random;
using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common {
    [TestClass]
    public class EntityTests : AbstractTests<ValueObject<TestData>> {
        private TestData data;

        private class testClass : Entity<TestData> {
            public testClass(TestData d) : base(d) { }
        }
        protected override object createObject() {
            data = GetRandom.Object<TestData>();
            return new testClass(data);
        }
        [TestMethod] public void ValidFromTest() => isProperty(data.From);
        [TestMethod] public void ValidToTest() => isProperty(data.To);
    }
}
