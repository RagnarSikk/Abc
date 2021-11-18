using Abc.Data.Others;
using Abc.Domain.Common;

namespace Abc.Domain.Others {
    public sealed class Service : UniqueEntity<ServiceData> {
        public Service(ServiceData d) : base(d) { }
        public string ServiceProviderRoleId => Data.ServiceProviderRoleId ?? Unspecified;
        public string ServiceTypeId => Data.ServiceTypeId ?? Unspecified;

        public ServiceType ServiceType => new GetFrom<IServiceTypeRepository, ServiceType>().ById(ServiceTypeId);


    }
}
