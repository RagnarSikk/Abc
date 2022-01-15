using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Common;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Common {

    [TestClass]
    public class UniqueEntitiesRepositoryTests : AbstractRepoTests<BodyMetricRepository, BodyMetric, BodyMetricData> {
        protected override object createObject()
            => new BodyMetricRepository(new InMemoryTrainingDbContext().TrainingDb);

        protected override BodyMetric toObject(BodyMetricData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(UniqueEntitiesRepository<BodyMetric, BodyMetricData>)));
        }
    }
}
