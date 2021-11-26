using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Other
{
    public class BodyMetricViewFactory : AbstractViewFactory<BodyMetricData, BodyMetric, BodyMetricView>
    {
        protected internal override BodyMetric toObject(BodyMetricData d) => new(d);
    }
}
