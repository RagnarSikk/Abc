using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Others {
    
    [TestClass]
    public class ServiceForPersonRepositoryTests : RepoTests<ServiceForPersonRepository, ServiceForPerson, ServiceForPersonData>
    {
        protected override object createObject()
            => new ServiceForPersonRepository(new InMemoryTrainingDbContext().TrainingDb);
        protected override ServiceForPerson toObject(ServiceForPersonData d) => new(d);
    }
}
