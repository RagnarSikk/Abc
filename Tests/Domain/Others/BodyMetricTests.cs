using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class BodyMetricTests : SealedTests<UniqueEntity<BodyMetricData>> {
        private BodyMetricData data;


        protected override object createObject() => new BodyMetric(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<BodyMetricData>();
            base.TestInitialize();
        }
        [TestMethod] public void PersonIdTest() => isProperty(data.PersonId);
        [TestMethod] public void BodyMetricTypeIdTest() => isProperty(data.BodyMetricTypeId);
        [TestMethod] public void ValueTest() => isProperty(data.Value);
        //[TestMethod] public void PersonTest() => isProperty(data.PersonId); //Todo xd nii vist ei saa jah

    }
}
