﻿using Abc.Domain.Customers;
using Abc.Infra.Common;
using Abc.Data.Customers;
using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Customers;

namespace Abc.Infra.Customers
{
    public sealed class AthletesRepository : UniqueEntitiesRepository<Athlete, AthleteData>, IAthletesRepository
    {
        public AthletesRepository(TrainingDbContext c) : base(c, c.Athletes) {}
        protected internal override Athlete toDomainObject(AthleteData d) => new Athlete(d);
    }
}
