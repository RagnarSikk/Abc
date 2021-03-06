using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;


namespace Abc.Domain.Others {
    public sealed class EquipmentForPerson : UniqueEntity<EquipmentForPersonData> {
        public EquipmentForPerson(EquipmentForPersonData d) : base(d) { }
        public string PersonId => Data.PersonId ?? Unspecified;
        public string PersonRoleTypeId => Data.PersonRoleTypeId ?? Unspecified;
        public string EquipmentId => Data.EquipmentId ?? Unspecified;
        public int Amount => Data?.Amount ?? UnspecifiedInteger;

        public Person Person => new GetFrom<IPersonRepository, Person>().ById(PersonId);
        public PersonRoleType PersonRoleType => new GetFrom<IPersonRoleTypeRepository, PersonRoleType>().ById(PersonRoleTypeId);
        public Equipment Equipment => new GetFrom<IEquipmentRepository, Equipment>().ById(EquipmentId);

    }
}
