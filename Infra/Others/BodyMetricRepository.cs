using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Infra.Common;

namespace Abc.Infra.Others
{
    public sealed class BodyMetricRepository : UniqueEntitiesRepository<BodyMetric, BodyMetricData>, IBodyMetricRepository
    {
        public BodyMetricRepository(TrainingDbContext c) : base(c, c.BodyMetrics) { }

        protected internal override BodyMetric toDomainObject(BodyMetricData d) => new BodyMetric(d);
    }
}
