using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Facade.People.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.People.Factories {
    [TestClass]
    public class PersonRoleTypeViewFactoryTests : FactoryBaseTests<PersonRoleTypeViewFactory, PersonRoleTypeData, PersonRoleType, PersonRoleTypeView> {
        protected override PersonRoleType createObject(PersonRoleTypeData d) => new(d);
    }
}
