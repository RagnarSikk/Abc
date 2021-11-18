using Abc.Data.People;
using Abc.Domain.People;
using Abc.Infra.Common;

namespace Abc.Infra.People {
    public sealed class PhysiotherapistsRepository : UniqueEntitiesRepository<Physiotherapist, PhysiotherapistData>, IPhysiotherapistsRepository {
        public PhysiotherapistsRepository(TrainingDbContext c) : base(c, c.Physiotherapists) { }
        protected internal override Physiotherapist toDomainObject(PhysiotherapistData d) => new Physiotherapist(d);

    }
}
