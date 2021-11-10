using Abc.Aids.Random;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.People {
    [TestClass]
    public class NutritionistTests : SealedTests<Person<NutritionistData>> {
        private NutritionistData data;
        protected override object createObject() => new Nutritionist(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<NutritionistData>();
            base.TestInitialize();
        }
        [TestMethod] public void ServiceProviderIdTest() => isProperty(data.ServiceProviderId);
    }
}
