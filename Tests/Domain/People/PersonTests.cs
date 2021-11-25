using Abc.Aids.Random;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.People {
    [TestClass]
    public class PersonTests : ClassTests<UniqueEntity<PersonData>> {
        private PersonData data;


        protected override object createObject() => new Person(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<PersonData>();
            base.TestInitialize();
        }
        [TestMethod] public void FirstMidNameTest() => isProperty(data.FirstMidName);
        [TestMethod] public void LastNameTest() => isProperty(data.LastName);
        [TestMethod] public void PhoneNumberTest() => isProperty(data.PhoneNumber);
        [TestMethod] public void EmailTest() => isProperty(data.Email);
        [TestMethod] public void GenderTest() => isProperty(data.Gender);
        [TestMethod] public void DateOfBirthTest() => isProperty(data.DateOfBirth);
    }
}