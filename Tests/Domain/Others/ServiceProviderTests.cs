//using Abc.Aids.Random;
//using Abc.Data.Others;
//using Abc.Domain.Common;
//using Abc.Domain.Others;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Abc.Tests.Domain.Others {
//    [TestClass]
//    public class ServiceProviderTests : SealedTests<UniqueEntity<ServiceProviderData>> {
//        private ServiceProviderData data;
//        protected override object createObject() => new ServiceProvider(data);

//        [TestInitialize]
//        public override void TestInitialize() {
//            data = GetRandom.Object<ServiceProviderData>();
//            base.TestInitialize();
//        }
//        [TestMethod] public void ServiceTypeIdTest() => isProperty(data.ServiceTypeId);
//        [TestMethod] public void PersonIdTest() => isProperty(data.PersonId);
//    }
//}
