using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.People;

namespace Abc.Domain.Others {
    public sealed class BodyMetric : UniqueEntity<BodyMetricData> {
        public BodyMetric(BodyMetricData d) : base(d) { }
        public string PersonId => Data.PersonId ?? Unspecified;
        public string BodyMetricTypeId => Data.BodyMetricTypeId ?? Unspecified;
        public double Weight => Data?.Weight ?? UnspecifiedDouble;
        public double Height => Data?.Height ?? UnspecifiedDouble;

        public Person Person => new GetFrom<IPersonRepository, Person>().ById(PersonId);
        public BodyMetricType BodyMetricType => new GetFrom<IBodyMetricTypeRepository, BodyMetricType>().ById(BodyMetricTypeId);
    }
}
