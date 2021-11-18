using Abc.Data.People;
using Abc.Domain.People;
using Abc.Infra.Common;

namespace Abc.Infra.People {
    public sealed class AdministratorsRepository : UniqueEntitiesRepository<Administrator, AdministratorData>, IAdministratorsRepository {
        public AdministratorsRepository(TrainingDbContext c) : base(c, c.Administrators) { }
        protected internal override Administrator toDomainObject(AdministratorData d) => new Administrator(d);

    }
}
