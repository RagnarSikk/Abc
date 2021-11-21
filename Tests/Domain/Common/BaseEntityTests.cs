using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Domain.Common {
    [TestClass]
    public class BaseEntityTests : AbstractTests<object> {
        private class testClass : BaseEntity { }
        protected override BaseEntity createObject() => new testClass();
        //private BaseEntity data;
        //protected override object createObject() => new BaseEntity(data);

        //[TestInitialize]
        //public override void TestInitialize() {
        //    data = GetRandom.Object<BaseEntityData>();
        //    base.TestInitialize();
        //}
        [TestMethod] public void UnspecifiedTest() => isProperty<string>();
        [TestMethod] public void UnspecifiedValidFromTest() => isProperty<DateTime?>();
        [TestMethod] public void UnspecifiedValidToTest() => isProperty<DateTime?>();
        [TestMethod] public void UnspecifiedDoubleTest() => isProperty<double>();
        [TestMethod] public void UnspecifiedDecimalTest() => isProperty<decimal>();
        [TestMethod] public void UnspecifiedIntegerTest() => isProperty<int>();

    }
}
