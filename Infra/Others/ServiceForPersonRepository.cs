using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Infra.Common;

namespace Abc.Infra.Others {
    public sealed class ServiceForPersonRepository : UniqueEntitiesRepository<ServiceForPerson, ServiceForPersonData>, IServiceForPersonRepository {
        public ServiceForPersonRepository(TrainingDbContext c) : base(c, c.ServicesForPerson) { }

        protected internal override ServiceForPerson toDomainObject(ServiceForPersonData d) => new ServiceForPerson(d);
    }
}
