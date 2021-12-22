using Abc.Data.Common;

namespace Abc.Data.Others {
    public sealed class EquipmentData : UniqueEntityData {
        public int Amount {  get; set; }
        public string PersonRoleTypeId { get; set; }
        public string EquipmentTypeId { get; set; }
    }
}
