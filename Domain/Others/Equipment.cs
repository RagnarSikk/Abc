using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;

namespace Abc.Domain.Others {
    public sealed class Equipment : UniqueEntity<EquipmentData> {
        public Equipment(EquipmentData d) : base(d) { }
        public int Amount => Data?.Amount ?? UnspecifiedInteger;
        public string PersonRoleTypeId => Data.PersonRoleTypeId ?? Unspecified;
        public string EquipmentTypeId => Data.EquipmentTypeId ?? Unspecified;

        public EquipmentType EquipmentType => new GetFrom<IEquipmentTypeRepository, EquipmentType>().ById(EquipmentTypeId);
        public PersonRoleType PersonRoleType => new GetFrom<IPersonRoleTypeRepository, PersonRoleType>().ById(PersonRoleTypeId);

    }

}
