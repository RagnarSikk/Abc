using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class ServiceTests : SealedTests<UniqueEntity<ServiceData>> {
        private ServiceData data;
        protected override object createObject() => new Service(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<ServiceData>();
            base.TestInitialize();
        }
        [TestMethod] public void ServiceTypeIdTest() => isProperty(data.ServiceTypeId);
        [TestMethod] public void ServiceProviderRoleIdTest() => isProperty(data.ServiceProviderRoleId);
    }
}
