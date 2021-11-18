﻿using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Others;
using Abc.Domain.People;
using Abc.Infra.Common;

namespace Abc.Infra.People
{
    public sealed class PersonRepository : UniqueEntitiesRepository<Person, PersonData>, IPersonRepository
    {
        public PersonRepository(TrainingDbContext c) : base(c, c.Persons) { }

        protected internal override Person toDomainObject(PersonData d) => new Person(d);
    }
}
