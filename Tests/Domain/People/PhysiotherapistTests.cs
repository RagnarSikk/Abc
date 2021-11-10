using Abc.Aids.Random;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.People {
    [TestClass]
    public class PhysiotherapistTests : SealedTests<Person<PhysiotherapistData>> {
        private PhysiotherapistData data;
        protected override object createObject() => new Physiotherapist(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<PhysiotherapistData>();
            base.TestInitialize();
        }
        [TestMethod] public void ServiceProviderIdTest() => isProperty(data.ServiceProviderId);
    }
}
