using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class ServiceTypeTests : SealedTests<DefinedEntity<ServiceTypeData>> {
        private ServiceTypeData data;
        protected override object createObject() => new ServiceType(data);
        [TestInitialize]
        public override void TestInitialize()
        {
            data = GetRandom.Object<ServiceTypeData>();
            base.TestInitialize();
        }
    }
}
