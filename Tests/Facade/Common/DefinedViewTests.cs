using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Common {

    [TestClass]
    public class DefinedViewTests : AbstractTests<NamedView> {

        private class testClass : DefinedView { }
        [TestMethod] public void DefinitionTest() => isDisplayProperty<string>("Definition");
        protected override object createObject() => new testClass();
    }

}