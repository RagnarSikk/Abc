using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Facade.People.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.People.Factories {
    [TestClass]
    public class PersonViewFactoryTests : FactoryBaseTests<PersonViewFactory, PersonData, Person, PersonView> {
        protected override Person createObject(PersonData d) => new(d);
    }
}
