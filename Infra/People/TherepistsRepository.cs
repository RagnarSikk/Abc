using Abc.Data.People;
using Abc.Domain.People;
using Abc.Infra.Common;

namespace Abc.Infra.People
{
    public sealed class TherepistsRepository : UniqueEntitiesRepository<Therapist, TherapistData>, ITherepistsRepository
    {
        public TherepistsRepository(TrainingDbContext c) : base(c, c.Therapists) { }
        protected internal override Therapist toDomainObject(TherapistData d) => new Therapist(d);
    }
}
