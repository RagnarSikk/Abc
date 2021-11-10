using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Data.Common {
    [TestClass]
    public class PeriodDataTests : AbstractTests<object> {
        private class testClass : PeriodData { }
        protected override PeriodData createObject() => new testClass();
        [TestMethod] public void FromTest() => isProperty<DateTime?>();
        [TestMethod] public void ToTest() => isProperty<DateTime?>();
    }

}
