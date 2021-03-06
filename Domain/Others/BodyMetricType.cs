using Abc.Data.Others;
using Abc.Domain.Common;

namespace Abc.Domain.Others {
    public sealed class BodyMetricType : DefinedEntity<BodyMetricTypeData> {
        public BodyMetricType(BodyMetricTypeData d) : base(d) { }
    }
}