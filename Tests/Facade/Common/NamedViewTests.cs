using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Common {

    [TestClass]
    public class NamedViewTests : AbstractTests<UniqueEntityView> {
        private class testClass : NamedView { }

        [TestMethod] public void CodeTest() => isDisplayProperty<string>("Code");
        [TestMethod] public void NameTest() => isRequiredProperty<string>("Name");

        protected override object createObject() => new testClass();
    }

}