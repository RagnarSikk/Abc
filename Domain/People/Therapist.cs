using Abc.Data.People;
using Abc.Domain.Common;

namespace Abc.Domain.People {
    public sealed class Therapist : Person<TherapistData> {
        public Therapist(TherapistData d) : base(d) { }

        public string ServiceProviderId => Data.ServiceProviderId ?? Unspecified;

    }
}
