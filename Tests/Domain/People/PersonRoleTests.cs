using Abc.Aids.Random;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.People {
    [TestClass]
    public class PersonRoleTests : ClassTests<UniqueEntity<PersonRoleData>> {
        private PersonRoleData data;

        protected override object createObject() => new PersonRole(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<PersonRoleData>();
            base.TestInitialize();
        }
        [TestMethod] public void PersonRoleTypeIdTest() => isProperty(data.PersonRoleTypeId);
        [TestMethod] public void PersonIdTest() => isProperty(data.PersonId);
        [TestMethod] public void CertificateTest() => isProperty(data.Certificate);

    }
}