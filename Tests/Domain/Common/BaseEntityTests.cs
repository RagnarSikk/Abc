using System;
using Abc.Aids.Random;
using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common
{
    [TestClass] public class BaseEntityTests : AbstractTests<object> {
        private class testClass : BaseEntity { }
        protected override object createObject() => new testClass();
        [TestMethod] public void UnspecifiedTest() => isProperty(Aids.Constants.Word.Unspecified);
        [TestMethod] public void UnspecifiedValidFromTest() => isProperty(DateTime.MinValue);
        [TestMethod] public void UnspecifiedValidToTest() => isProperty(DateTime.MaxValue);
        [TestMethod] public void UnspecifiedDoubleTest() => isProperty(double.NaN);
        [TestMethod] public void UnspecifiedDecimalTest() => isProperty(decimal.MaxValue);
        [TestMethod] public void UnspecifiedIntegerTest() => isProperty(0);
    }

}
