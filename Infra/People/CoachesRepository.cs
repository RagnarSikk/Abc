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
    public sealed class CoachesRepository : UniqueEntitiesRepository<Coach, CoachData>, ICoachesRepository
    {
        public CoachesRepository(TrainingDbContext c) : base(c, c.Coaches) { }
        protected internal override Coach toDomainObject(CoachData d) => new Coach(d);
    }
}
