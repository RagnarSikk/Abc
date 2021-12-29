using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others
{
    [TestClass]
    public class EquipmentForPersonTests :SealedTests<UniqueEntity<EquipmentForPersonData>>
    {
        private EquipmentForPersonData data;
        private IPersonRepository personRepo;
        private IEquipmentRepository equipmentRepo;
        private PersonData personData;
        private EquipmentData equipmentData;
        private EquipmentForPerson equipmentForPerson;

        //private class MockPersonRepository : MockRepo<Person>, IPersonRepository { }
        //private class MockServiceRepository : MockRepo<Equipment>, IEquipmentRepository { }

        protected override object createObject() => new EquipmentForPerson(data);
        [TestInitialize] public override void TestInitialize()
        {
            data = GetRandom.Object<EquipmentForPersonData>();
            personRepo = MockRepos.PersonRepository(data.PersonId, out personData);
            equipmentRepo = MockRepos.EquipmentRepository(data.EquipmentId, out equipmentData);
            base.TestInitialize();
            equipmentForPerson = obj as EquipmentForPerson;
        }

        [TestMethod] public void PersonIdTest() => isProperty(data.PersonId);
        [TestMethod] public void EquipmentIdTest() => isProperty(data.EquipmentId);
        [TestMethod] public void PersonTest() 
        {
            isNull(equipmentForPerson.Person);
            GetRepository.SetServiceProvider(new MockServiceProvider(personRepo));
            areEqualProperties(personData, equipmentForPerson.Person.Data);
        }
        [TestMethod] public void EquipmentTest()
        {
            isNull(equipmentForPerson.Equipment);
            GetRepository.SetServiceProvider(new MockServiceProvider(equipmentRepo));
            areEqualProperties(equipmentData, equipmentForPerson.Equipment.Data);
        }
    } 
}
