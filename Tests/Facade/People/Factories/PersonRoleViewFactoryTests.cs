using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Facade.People.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.People.Factories {
    [TestClass]
    public class PersonRoleViewFactoryTests : FactoryBaseTests<PersonRoleViewFactory, PersonRoleData, PersonRole, PersonRoleView> {
        protected override PersonRole createObject(PersonRoleData d) => new(d);
    }
}
