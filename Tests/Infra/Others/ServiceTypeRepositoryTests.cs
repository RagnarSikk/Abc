using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others {

    [TestClass]
    public class ServiceTypeRepositoryTests : RepoTests<ServiceTypeRepository, ServiceType, ServiceTypeData> {
        protected override object createObject()
            => new ServiceTypeRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override ServiceType toObject(ServiceTypeData d) => new(d);
    }
}
