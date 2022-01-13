using Abc.Data.People;
using Abc.Domain.People;
using Abc.Infra.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.People {
    [TestClass]
    public class PersonRepositoryTests : RepoTests<PersonRepository, Person, PersonData> {
        protected override object createObject()
            => new PersonRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override Person toObject(PersonData d) => new(d);
    }
}
