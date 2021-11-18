using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Common;

namespace Abc.Infra.Others {
    public sealed class ServiceRepository : UniqueEntitiesRepository<Service, ServiceData>, IServiceRepository {
        public ServiceRepository(TrainingDbContext c) : base(c, c.Services) { }

        protected internal override Service toDomainObject(ServiceData d) => new Service(d);
    }
}
