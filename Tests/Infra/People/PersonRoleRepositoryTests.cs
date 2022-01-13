using Abc.Data.People;
using Abc.Domain.People;
using Abc.Infra.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.People {
    [TestClass]
    public class PersonRoleRepositoryTests : RepoTests<PersonRoleRepository, PersonRole, PersonRoleData> {
        protected override object createObject()
            => new PersonRoleRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override PersonRole toObject(PersonRoleData d) => new(d);
    }
}
