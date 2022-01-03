
using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Common;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Common
{

    [TestClass]
    public class FilteredRepositoryTests : AbstractRepoTests<BodyMetricRepository, BodyMetric, BodyMetricData> {
        protected override object createObject()
            => new BodyMetricRepository(new InMemoryTrainingDbContext().TrainingDb);

        protected override BodyMetric toObject(BodyMetricData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(SortedRepository<BodyMetric,BodyMetricData>)));
        }
        [TestMethod] public void SearchStringTest() => isProperty<string>();
        [TestMethod] public void CurrentFilterTest() => isProperty<string>();
        [TestMethod] public void FixedFilterTest() => isProperty<string>();
        [TestMethod] public void FixedValueTest() => isProperty<string>();
        [TestMethod]
        public void SqlQueryTest() {
            var b = repo.createSqlQuery().Expression.ToString();
            isFalse(b.Contains(".Where"));
            repo.SearchString = random<string>();
            b = repo.createSqlQuery().Expression.ToString();
            isTrue(b.Contains(".Where"));
        }
    }
}