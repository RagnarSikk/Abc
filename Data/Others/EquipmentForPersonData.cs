using Abc.Data.Common;

namespace Abc.Data.Others {
    public sealed class EquipmentForPersonData : UniqueEntityData {
        public string PersonId { get; set; }
        public string PersonRoleTypeId { get; set; }
        public string EquipmentId { get; set; }
        public int Amount { get; set; }
    }
}
