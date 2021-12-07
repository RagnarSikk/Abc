using Abc.Data.Common;

namespace Abc.Data.Others {
    public sealed class BodyMetricData : UniqueEntityData {
        public double Value { get; set; }
        public string BodyMetricTypeId { get; set; }
        public string PersonId { get; set; }
    }
}
