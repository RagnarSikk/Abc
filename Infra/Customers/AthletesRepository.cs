using Abc.Data.Customers;
using Abc.Domain.Customers;
using Abc.Infra.Common;

namespace Abc.Infra.Customers {
    public sealed class AthletesRepository : UniqueEntitiesRepository<Athlete, AthleteData>, IAthletesRepository {
        public AthletesRepository(TrainingDbContext c) : base(c, c.Athletes) { }
        protected internal override Athlete toDomainObject(AthleteData d) => new Athlete(d);
    }
}
