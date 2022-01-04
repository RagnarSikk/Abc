using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others {
    [TestClass]
    public class BodyMetricTypeRepositoryTests : RepoTests<BodyMetricTypeRepository, BodyMetricType, BodyMetricTypeData>
    {
        protected override object createObject()
            => new BodyMetricTypeRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override BodyMetricType toObject(BodyMetricTypeData d) => new(d);
    }
}