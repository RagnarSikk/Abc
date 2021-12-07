using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Common;

namespace Abc.Infra.Others
{
    public sealed class BodyMetricTypeRepository : UniqueEntitiesRepository<BodyMetricType, BodyMetricTypeData>, IBodyMetricTypeRepository
    {
        public BodyMetricTypeRepository(TrainingDbContext c) : base(c, c.BodyMetricTypes) { }

        protected internal override BodyMetricType toDomainObject(BodyMetricTypeData d) => new BodyMetricType(d);
    }
}