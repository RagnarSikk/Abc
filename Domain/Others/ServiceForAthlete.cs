using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.People;

namespace Abc.Domain.Others {
    public sealed class ServiceForAthlete : UniqueEntity<ServiceForAthleteData> {
        public ServiceForAthlete(ServiceForAthleteData d) : base(d) { }
        public string PersonId => Data.PersonId ?? Unspecified;
        public string ServiceId => Data.ServiceId ?? Unspecified;

        public Person Person => new GetFrom<IPersonRepository, Person>().ById(PersonId);
        public Service Service => new GetFrom<IServiceRepository, Service>().ById(ServiceId);

    }
}
