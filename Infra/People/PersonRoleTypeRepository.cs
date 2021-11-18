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
    public sealed class PersonRoleTypeRepository : UniqueEntitiesRepository<PersonRoleType, PersonRoleTypeData>, IPersonRoleTypeRepository
    {
        public PersonRoleTypeRepository(TrainingDbContext c) : base(c, c.PersonRoleTypes) { }

        protected internal override PersonRoleType toDomainObject(PersonRoleTypeData d) => new PersonRoleType(d);
    }
}
