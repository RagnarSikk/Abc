using Abc.Data.Common;

namespace Abc.Data.Others {
    public sealed class EquipmentData : UniqueEntityData {
        public int AmountAvailable { get; set; }
        public int AmountInUsing { get; set; }
    }
}
