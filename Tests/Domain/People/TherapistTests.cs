using Abc.Aids.Random;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.People {
    [TestClass]
    public class TherapistTests : SealedTests<Person<TherapistData>> {
        private TherapistData data;
        protected override object createObject() => new Therapist(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<TherapistData>();
            base.TestInitialize();
        }
        [TestMethod] public void ServiceProviderIdTest() => isProperty(data.ServiceProviderId);
    }
}
