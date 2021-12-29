using Abc.Aids.Random;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.People {
    [TestClass]
    public class PersonRoleTests : SealedTests<UniqueEntity<PersonRoleData>> {
        private PersonRoleData data;
        private PersonData personData;
        private PersonRoleTypeData personRoleTypeData;
        private IPersonRepository personRepo;
        private IPersonRoleTypeRepository personRoleTypeRepo;
        private PersonRole personRole;

        protected override object createObject() => new PersonRole(data);

        [TestMethod] public void PersonRoleTypeIdTest() => isProperty(data.PersonRoleTypeId);
        [TestMethod] public void PersonIdTest() => isProperty(data.PersonId);
        [TestMethod] public void CertificateTest() => isProperty(data.Certificate);
        

        [TestInitialize]
        public override void TestInitialize()
        {
            data = GetRandom.Object<PersonRoleData>();
            personRepo = MockRepos.PersonRepository(data.PersonId, out personData);
            personRoleTypeRepo = MockRepos.PersonRoleTypeRepository(data.PersonRoleTypeId, out personRoleTypeData);
            base.TestInitialize();
            personRole = obj as PersonRole;
        }

        [TestMethod]
        public void PersonTest()
        {
            isNull(personRole.Person);
            GetRepository.SetServiceProvider(new MockServiceProvider(personRepo));
            areEqualProperties(personData, personRole.Person.Data);
        }
        [TestMethod]
        public void PersonRoleTypeTest()
        {
            isNull(personRole.PersonRoleType);
            GetRepository.SetServiceProvider(new MockServiceProvider(personRoleTypeRepo));
            areEqualProperties(personRoleTypeData, personRole.PersonRoleType.Data);
        }
    }
}