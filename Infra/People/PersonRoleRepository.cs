using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Data.People;
using Abc.Domain.People;
using Abc.Infra.Common;

namespace Abc.Infra.People
{
    public sealed class PersonRoleRepository : UniqueEntitiesRepository<PersonRole, PersonRoleData>, IPersonRoleRepository
    {
        public PersonRoleRepository(TrainingDbContext c) : base(c, c.PersonRoles) { }

        protected internal override PersonRole toDomainObject(PersonRoleData d) => new PersonRole(d);
    }
}
