using Abc.Domain.Common;
using Abc.Domain.People.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common {
    [TestClass] public class GetRepositoryTests : BaseTests {
        private IPersonRepository personRepo;
        private IPersonRoleTypeRepository personRoleTypeRepo;
        private IPersonRoleRepository personRoleRepo;
        private MockServiceProvider provider;

        [TestInitialize] public void TestInitialize() {
            type = typeof(GetRepository);
            personRepo = MockRepos.Person();
            personRoleTypeRepo = MockRepos.personRoleType();
            personRoleRepo = MockRepos.PersonRole();
            provider = new MockServiceProvider(personRepo, personRoleTypeRepo, personRoleRepo);
            GetRepository.SetServiceProvider(null);
        }
        [TestMethod] public void SetServiceProviderTest() {
            isNull(GetRepository.services);
            GetRepository.SetServiceProvider(provider);
            Assert.AreSame(provider, GetRepository.services);
        }
        [TestMethod] public void InstanceTest() {
            GetRepository.SetServiceProvider(provider);
            var r = GetRepository.Instance(typeof(IPersonRepository));
            Assert.AreSame(r, personRepo);
        }
        [TestMethod] public void InstanceByTypeTest()
        {
            GetRepository.SetServiceProvider(provider);
            var r = GetRepository.Instance<IPersonRoleRepository>();
            Assert.AreSame(r, personRoleRepo);
        }
    }
}
