using Abc.Data.Others;
using Abc.Domain.Common;

namespace Abc.Domain.Others {
    public sealed class ServiceProvider : UniqueEntity<ServiceProviderData> {
        public ServiceProvider(ServiceProviderData d) : base(d) { }
        public string PersonId => Data.PersonId ?? Unspecified;
        public string ServiceTypeId => Data.ServiceTypeId ?? Unspecified;
    }
}
