using Abc.Data.Common;

namespace Abc.Data.Others {
    public sealed class BodyMetricData : UniqueEntityData {
        public double Weight { get; set; }
        public double Height { get; set; }
        public string PersonId { get; set; }
        public string BodyMetricTypeId { get; set; }
    }
}
