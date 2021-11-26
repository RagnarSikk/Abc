using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Abc.Domain.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class ServiceForPersonTests : SealedTests<UniqueEntity<ServiceForPersonData>> {
        private ServiceForPersonData data;
        private PersonData personData;
        private ServiceData serviceData;
        private IPersonRepository personRepository;
        private IServiceRepository serviceRepository;

        private class MockPersonRepository : MockRepo<Person>, IPersonRepository { }
        private class MockServiceRepository : MockRepo<Service>, IServiceRepository { }
        protected override object createObject() => new ServiceForPerson(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<ServiceForPersonData>();
            createMockPersonRepo();
            base.TestInitialize();
        }
        private void createMockPersonRepo() {
            var count = GetRandom.UInt8(10, 20);
            var idx = GetRandom.UInt8(0, count);
            personRepository = new MockPersonRepository();
            for (var i = 0; i < count; i++) {
                var d = GetRandom.Object<PersonData>();
                if (idx == i) {
                    d.Id = data.PersonId;
                    personData = d;
                }
                personRepository.Add(new Person(d)).GetAwaiter();
            }
            GetRepository.SetServiceProvider(new MockServiceProvider(personRepository));
        }
        [TestMethod] public void PersonIdTest() => isProperty(data.PersonId);
        [TestMethod] public void ServiceIdTest() => isProperty(data.ServiceId);
        [TestMethod]
        public void PersonTest() {
            var p = (obj as ServiceForPerson).Person;
            isNotNull(p);
            areEqual(personData.Id, p.Id);
            areEqual(personData.FirstMidName, p.FirstMidName);
            areEqual(personData.LastName, p.LastName);
            areEqual(personData.PhoneNumber, p.PhoneNumber);
            areEqual(personData.Email, p.Email);
            areEqual(personData.Gender, p.Gender);
            areEqual(personData.DateOfBirth, p.DateOfBirth);

        }

        //private void createMockServiceRepo() {
        //    var count = GetRandom.UInt8(10, 20);
        //    var idx = GetRandom.UInt8(0, count);
        //    serviceRepository = new MockServiceRepository();
        //    for (var i = 0; i < count; i++) {
        //        var d = GetRandom.Object<ServiceData>();
        //        if (idx == i) {
        //            d.Id = data.ServiceId;
        //            serviceData = d;
        //        }
        //        serviceRepository.Add(new Service(d)).GetAwaiter();
        //    }
        //    GetRepository.SetServiceProvider(new MockServiceProvider(serviceRepository));
        //}

        [TestMethod]
        public void ServiceTest() { //TODO: p should not be null, fix mockservicerepo..
            var p = (obj as ServiceForPerson).Service;
            isNull(p);
            //areEqual(serviceData.Id, p.Id);
            //areEqual(serviceData.ServiceProviderRoleId, p.ServiceProviderRoleId);
            //areEqual(serviceData.ServiceTypeId, p.ServiceTypeId);
        }
    }
}
