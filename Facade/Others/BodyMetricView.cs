using Abc.Facade.Common;

namespace Abc.Facade.Others {
    public sealed class BodyMetricView : UniqueEntityView {
        public double Weight { get; set; }
        public double Height { get; set; }
        public string PersonId { get; set; }
        public string BodyMetricTypeId { get; set; }
    }
}
