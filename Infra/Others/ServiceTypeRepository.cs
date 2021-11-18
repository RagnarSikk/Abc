using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Common;

namespace Abc.Infra.Others {
    public class ServiceTypeRepository : UniqueEntitiesRepository<ServiceType, ServiceTypeData>, IServiceTypeRepository {
        public ServiceTypeRepository(TrainingDbContext c) : base(c, c.ServiceTypes) { }

        protected internal override ServiceType toDomainObject(ServiceTypeData d) => new(d);
    }
}
