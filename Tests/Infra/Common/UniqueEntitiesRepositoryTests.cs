using Abc.Infra;
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
    public class UniqueEntitiesRepositoryTests : AbstractRepoTests<BodyMetricRepository, BodyMetric, BodyMetricData> {
        protected override object createObject()
            => new BodyMetricRepository(new InMemoryTrainingDbContext().TrainingDb);

        protected override BodyMetric toObject(BodyMetricData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(PaginatedRepository<BodyMetric, BodyMetricData>)));
        }
    }
}
