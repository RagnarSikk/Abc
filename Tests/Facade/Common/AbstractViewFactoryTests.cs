using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;
using Abc.Facade.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Common {
    [TestClass] public class AbstractViewFactoryTests : AbstractTests<object> {
        private class testClass : AbstractViewFactory<PersonRoleData, PersonRole, PersonRoleView> {
            protected override PersonRole toObject(PersonRoleData d) => new (d);
        }
        [TestMethod] public void CreateTest() {}
        [TestMethod] public void CreateObjectTest() {
            var v = random<PersonRoleView>();
            var o = (obj as testClass).Create(v);
            areEqualProperties(v, o.Data);
        }
        [TestMethod] public void CreateViewTest() {
            var d = random<PersonRoleData>();
            var v = (obj as testClass).Create(new PersonRole(d));
            areEqualProperties(d, v);
        }
        protected override object createObject() => new testClass();
    }
}
