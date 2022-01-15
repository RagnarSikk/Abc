using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others.Factories {
    public sealed class BodyMetricViewFactory : AbstractViewFactory<BodyMetricData, BodyMetric, BodyMetricView> {
        protected internal override BodyMetric toObject(BodyMetricData d) => new(d);
    }
}
