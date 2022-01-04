using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others {
    [TestClass]
    public class BodyMetricRepositoryTests : RepoTests<BodyMetricRepository, BodyMetric, BodyMetricData>
    {
        protected override object createObject()
            => new BodyMetricRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override BodyMetric toObject(BodyMetricData d) => new(d);
    }
}
