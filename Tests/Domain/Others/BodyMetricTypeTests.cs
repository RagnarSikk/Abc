using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class BodyMetricTypeTests : SealedTests<DefinedEntity<BodyMetricTypeData>>
    {
        private BodyMetricTypeData data;
        protected override object createObject() => new BodyMetricType(data);
        [TestInitialize]
        public override void TestInitialize()
        {
            data = GetRandom.Object<BodyMetricTypeData>();
            base.TestInitialize();
        }
    }
}