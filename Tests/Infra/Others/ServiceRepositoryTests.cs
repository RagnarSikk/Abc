using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others {
    [TestClass]
    public class ServiceRepositoryTests : RepoTests<ServiceRepository, Service, ServiceData>
    {
        protected override object createObject()
            => new ServiceRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override Service toObject(ServiceData d) => new(d);
    }
}
