using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class ServiceTests : SealedTests<UniqueEntity<ServiceData>> {
        private ServiceData data;
        private ServiceTypeData serviceTypeData;
        private IServiceTypeRepository serviceTypeRepository;

        private class MockServiceTypeRepository : MockRepo<ServiceType>, IServiceTypeRepository { }
        protected override object createObject() => new Service(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<ServiceData>();
            createMockServiceRepo();
            base.TestInitialize();
        }
        private void createMockServiceRepo() {
            var count = GetRandom.UInt8(10, 20);
            var idx = GetRandom.UInt8(0, count);
            serviceTypeRepository = new MockServiceTypeRepository();
            for (var i = 0; i < count; i++) {
                var d = GetRandom.Object<ServiceTypeData>();
                if (idx == i) {
                    d.Id = data.ServiceTypeId;
                    serviceTypeData = d;
                }
                serviceTypeRepository.Add(new ServiceType(d)).GetAwaiter();
            }
            GetRepository.SetServiceProvider(new MockServiceProvider(serviceTypeRepository));
        }
        [TestMethod] public void ServiceTypeIdTest() => isProperty(data.ServiceTypeId);
        [TestMethod] public void ServiceProviderRoleIdTest() => isProperty(data.ServiceProviderRoleId);
        [TestMethod]
        public void ServiceTypeTest() {
            var p = (obj as Service).ServiceType;
            isNotNull(p);
            areEqual(serviceTypeData.Id, p.Id);
            areEqual(serviceTypeData.Name, p.Name);
            areEqual(serviceTypeData.Definition, p.Definition);
        }
    }
}
