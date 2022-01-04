using Abc.Data.People;
using Abc.Domain.People;
using Abc.Infra.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.People {
    [TestClass]
    public class PersonRoleTypeRepositoryTests : RepoTests<PersonRoleTypeRepository, PersonRoleType, PersonRoleTypeData>
    {
        protected override object createObject()
            => new PersonRoleTypeRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override PersonRoleType toObject(PersonRoleTypeData d) => new(d);
    }
}
