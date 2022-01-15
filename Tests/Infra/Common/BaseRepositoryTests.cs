using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Common;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Common {

    [TestClass]
    public class BaseRepositoryTests
        : AbstractRepoTests<BodyMetricRepository, BodyMetric, BodyMetricData> {
        protected override object createObject()
            => new BodyMetricRepository(new InMemoryTrainingDbContext().TrainingDb);

        protected override BodyMetric toObject(BodyMetricData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest()
        {
            var b = getBaseClass();
            areEqual(typeof(object), b);
        }
        [TestMethod]
        public void SqlQueryTest() {
            var b = repo.createSqlQuery().Expression.ToString();
            isTrue(b.Contains(".Select"));
        }
    }
}