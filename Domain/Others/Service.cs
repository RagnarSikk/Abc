using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;

namespace Abc.Domain.Others {
    public sealed class Service : UniqueEntity<ServiceData> {
        public Service(ServiceData d) : base(d) { }
        public string PersonRoleTypeId => Data.PersonRoleTypeId ?? Unspecified;
        public string ServiceTypeId => Data.ServiceTypeId ?? Unspecified;

        public ServiceType ServiceType => new GetFrom<IServiceTypeRepository, ServiceType>().ById(ServiceTypeId);
        public PersonRoleType PersonRoleType => new GetFrom<IPersonRoleTypeRepository, PersonRoleType>().ById(PersonRoleTypeId);
    }
}
