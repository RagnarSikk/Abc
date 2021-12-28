using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;

namespace Abc.Domain.Others {
    public sealed class ServiceForPerson : UniqueEntity<ServiceForPersonData> {
        public ServiceForPerson(ServiceForPersonData d) : base(d) { }
        public string PersonId => Data.PersonId ?? Unspecified;
        public string ServiceId => Data.ServiceId ?? Unspecified;

        public Person Person => new GetFrom<IPersonRepository, Person>().ById(PersonId);
        public Service Service => new GetFrom<IServiceRepository, Service>().ById(ServiceId);

    }
}
