using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Common;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Common {

    [TestClass]
    public class PaginatedRepositoryTests : AbstractRepoTests<BodyMetricRepository, BodyMetric, BodyMetricData> {
        protected override object createObject()
            => new BodyMetricRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override BodyMetric toObject(BodyMetricData d) => new(d);
        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(FilteredRepository<BodyMetric, BodyMetricData>)));
        }
        [TestMethod] public void PageIndexTest() => isProperty<int>(false);
        [TestMethod] public void TotalPagesTest() => isProperty(repo.getTotalPages(repo.PageSize));
        [TestMethod] public void HasNextPageTest() => isBooleanProperty(repo.PageIndex < repo.TotalPages);
        [TestMethod] public void HasPreviousPageTest() => isBooleanProperty(repo.PageIndex > 1);
        [TestMethod] public void PageSizeTest() => isProperty<int>(false);
        [TestMethod]
        public void SqlQueryTest() {
            var b = repo.createSqlQuery().Expression.ToString();
            isFalse(b.Contains(".Skip"));
            isFalse(b.Contains(".Take"));
            repo.PageIndex = 1;
            b = repo.createSqlQuery().Expression.ToString();
            isTrue(b.Contains(".Skip"));
            isTrue(b.Contains(".Take"));
        }
    }
}