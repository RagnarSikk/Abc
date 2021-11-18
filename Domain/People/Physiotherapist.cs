using Abc.Data.People;
using Abc.Domain.Common;

namespace Abc.Domain.People {
    public sealed class Physiotherapist : Person<PhysiotherapistData> {
        public Physiotherapist(PhysiotherapistData d) : base(d) { }

        public string ServiceProviderId => Data.ServiceProviderId ?? Unspecified;

    }
}
