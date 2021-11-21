using Abc.Data.People;
using Abc.Domain.People;
using Abc.Infra.Common;

namespace Abc.Infra.People {
    public sealed class PersonRoleRepository : UniqueEntitiesRepository<PersonRole, PersonRoleData>, IPersonRoleRepository {
        public PersonRoleRepository(TrainingDbContext c) : base(c, c.PersonRoles) { }

        protected internal override PersonRole toDomainObject(PersonRoleData d) => new PersonRole(d);
    }
}
