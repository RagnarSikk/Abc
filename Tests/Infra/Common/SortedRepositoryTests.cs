using Abc.Infra.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;

namespace Abc.Tests.Infra.Common
{

    [TestClass]
    public class SortedRepositoryTests : AbstractRepoTests<BodyMetricRepository, BodyMetric, BodyMetricData> {
        protected override object createObject()
            => new BodyMetricRepository(new InMemoryTrainingDbContext().TrainingDb);

        protected override BodyMetric toObject(BodyMetricData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(BaseRepository<BodyMetric, BodyMetricData>)));
        }

        [TestMethod] public void SortOrderTest() => isProperty<string>();
        [TestMethod] public void DescendingStringTest() => isProperty("_desc");

        public void SqlQueryTest(string s, bool hasOrderBy, bool hasDescending) {
            repo.SortOrder = s;
            var b = repo.createSqlQuery().Expression.ToString();
            areEqual(hasOrderBy, b.Contains(".OrderBy"));
            areEqual(hasDescending, b.Contains(".OrderByDescending"));
        }
    }
}