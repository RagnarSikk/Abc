using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.People.Repositories;

namespace Abc.Domain.People {
    public sealed class PersonRole : UniqueEntity<PersonRoleData> {
        public PersonRole(PersonRoleData d) : base(d) { }
        public string PersonRoleTypeId => Data.PersonRoleTypeId ?? Unspecified;
        public string PersonId => Data.PersonId ?? Unspecified;
        public string Certificate => Data.Certificate ?? Unspecified;

        public Person Person => new GetFrom<IPersonRepository, Person>().ById(PersonId);
        public PersonRoleType PersonRoleType => new GetFrom<IPersonRoleTypeRepository, PersonRoleType>().ById(PersonRoleTypeId);
    }
}
