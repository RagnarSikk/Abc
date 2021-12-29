using Abc.Data.Common;

namespace Abc.Data.Others {
    public sealed class EquipmentForPersonData : NamedEntityData {
        public string PersonId { get; set; }
        public string EquipmentId { get; set; }
    }
}
