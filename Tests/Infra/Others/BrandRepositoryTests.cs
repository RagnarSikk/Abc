using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others
{
    [TestClass]
    public class BrandRepositoryTests : RepoTests<BrandRepository, Brand, BrandData>
    {
        protected override object createObject()
            => new BrandRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override Brand toObject(BrandData d) => new(d);
    }
}