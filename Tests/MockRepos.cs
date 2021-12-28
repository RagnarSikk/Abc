using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Aids.Random;
using Abc.Data.Common;
using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;

namespace Abc.Tests
{
    internal static class MockRepos
    {
        public static IBodyMetricRepository BodyMetricRepository(string id, out BodyMetricData d)
            => createMockRepo<MockBodyMetricRepo, BodyMetric, BodyMetricData>( 
                id, d => new BodyMetric(d), out d);
        public static IBodyMetricTypeRepository BodyMetricTypeRepository(string id, out BodyMetricTypeData d)
            => createMockRepo<MockBodyMetricTypeRepo, BodyMetricType, BodyMetricTypeData>(
                id, d => new BodyMetricType(d), out d);
        public static IEquipmentForPersonRepository EquipmentForPersonRepository(string id, out EquipmentForPersonData d)
            => createMockRepo<MockEquipmentForPersonRepo, EquipmentForPerson, EquipmentForPersonData>(
                id, d => new EquipmentForPerson(d), out d);
        public static IEquipmentRepository EquipmentRepository(string id, out EquipmentData d)
            => createMockRepo<MockEquipment, Equipment, EquipmentData>(
                id, d => new Equipment(d), out d);
        public static IEquipmentTypeRepository EquipmentTypeRepository(string id, out EquipmentTypeData d)
            => createMockRepo<MockEquipmentType, EquipmentType, EquipmentTypeData>(
                id, d => new EquipmentType(d), out d);
        public static IServiceForPersonRepository ServiceForPerson(string id, out ServiceForPersonData d)
            => createMockRepo<MockServiceForPerson, ServiceForPerson, ServiceForPersonData>(
                id, d => new ServiceForPerson(d), out d);

        public static IServiceRepository ServiceRepository(string id, out ServiceData d)
            => createMockRepo<MockService, Service, ServiceData>(
                id, d => new Service(d), out d);
        public static IServiceTypeRepository ServiceTypeRepository(string id, out ServiceTypeData d)
            => createMockRepo<MockServiceType, ServiceType, ServiceTypeData>(
                id, d => new ServiceType(d), out d);
        public static IPersonRepository PersonRepository(string id, out PersonData d)
            => createMockRepo<MockPerson, Person, PersonData>(
                id, d => new Person(d), out d);
        public static IPersonRoleRepository PersonRoleRepository(string id, out PersonRoleData d)
            => createMockRepo<MockPersonRole, PersonRole, PersonRoleData>(
                id, d => new PersonRole(d), out d);

        public static IPersonRoleTypeRepository PersonRoleTypeRepository(string id, out PersonRoleTypeData d)
            => createMockRepo<MockPersonRoleType, PersonRoleType, PersonRoleTypeData>(
                id, d => new PersonRoleType(d), out d);


        internal static IBodyMetricRepository BodyMetric()
            => createMockRepo<MockBodyMetricRepo, BodyMetric, BodyMetricData>();
        internal static IBodyMetricTypeRepository BodyMetrictype()
            => createMockRepo<MockBodyMetricTypeRepo, BodyMetricType, BodyMetricTypeData>();
        internal static IEquipmentForPersonRepository EquipmentForPerson()
            => createMockRepo<MockEquipmentForPersonRepo, EquipmentForPerson, EquipmentForPersonData>();
        internal static IEquipmentRepository Equipment()
            => createMockRepo<MockEquipment, Equipment, EquipmentData>();
        internal static IEquipmentTypeRepository EquipmentType()
            => createMockRepo<MockEquipmentType, EquipmentType, EquipmentTypeData>();
        internal static IServiceForPersonRepository ServiceForPerson()
            => createMockRepo<MockServiceForPerson, ServiceForPerson, ServiceForPersonData>();
        internal static IServiceRepository Service()
            => createMockRepo<MockService, Service, ServiceData>();
        internal static IServiceTypeRepository ServiceType()
            => createMockRepo<MockServiceType, ServiceType, ServiceTypeData>();
        internal static IPersonRepository Person()
            => createMockRepo<MockPerson, Person, PersonData>();
        internal static IPersonRoleRepository PersonRole()
            => createMockRepo<MockPersonRole, PersonRole, PersonRoleData>();
        internal static IPersonRoleTypeRepository personRoleType()
            => createMockRepo<MockPersonRoleType, PersonRoleType, PersonRoleTypeData>();


        private class MockBodyMetricRepo : MockRepo<BodyMetric>, IBodyMetricRepository { }
        private class MockBodyMetricTypeRepo : MockRepo<BodyMetricType>, IBodyMetricTypeRepository { }
        private class MockEquipmentForPersonRepo : MockRepo<EquipmentForPerson>, IEquipmentForPersonRepository { }
        private class MockEquipment : MockRepo<Equipment>, IEquipmentRepository { }
        private class MockEquipmentType : MockRepo<EquipmentType>, IEquipmentTypeRepository { }
        private class MockServiceForPerson : MockRepo<ServiceForPerson>, IServiceForPersonRepository { }
        private class MockService: MockRepo<Service>, IServiceRepository{ }
        private class MockServiceType : MockRepo<ServiceType>, IServiceTypeRepository { }
        private class MockPerson : MockRepo<Person>, IPersonRepository { }
        private class MockPersonRole : MockRepo<PersonRole>, IPersonRoleRepository { }
        private class MockPersonRoleType : MockRepo<PersonRoleType>, IPersonRoleTypeRepository { }

        private static TRepo createMockRepo<TRepo, TObj, TData>()
            where TRepo : IRepository<TObj>, new()
            where TData : UniqueEntityData => new TRepo();

        private static TRepo createMockRepo<TRepo, TObj, TData>(string id, Func<TData, TObj> toObject, out TData data)
            where TRepo : IRepository<TObj>, new()
            where TData : UniqueEntityData
        {
            data = null;
            var count = GetRandom.UInt8(10, 20);
            var idx = GetRandom.UInt8(0, count);
            var repo = new TRepo();
            for (var i = 0; i < count; i++)
            {
                var d = GetRandom.Object<TData>();
                if (idx == i)
                {
                    d.Id = id;
                    data = d;
                }
                repo.Add(toObject(d)).GetAwaiter();
            }
            return repo;
        }

        private static TRepo createMockRepo<TRepo, TObj, TData>(
            Func<TData, TData> setRelatedId, Func<TData, TObj> toObject, out int itemsCount)
            where TRepo : IRepository<TObj>, new()
            where TData : UniqueEntityData
        {
            itemsCount = GetRandom.UInt8(3, 7);

            var repo = new TRepo();
            for (var i = 0; i < itemsCount; i++)
            {
                if (GetRandom.Bool()) repo.Add(toObject(GetRandom.Object<TData>())).GetAwaiter();
                var d = GetRandom.Object<TData>();
                d = setRelatedId(d);
                repo.Add(toObject(d)).GetAwaiter();
                if (GetRandom.Bool()) repo.Add(toObject(GetRandom.Object<TData>())).GetAwaiter();
            }
            return repo;
        }
    }
}
