using Abc.Data.Others;
using Abc.Domain.Common;

namespace Abc.Domain.Others {
    public sealed class EquipmentType : DefinedEntity<EquipmentTypeData> {
        public EquipmentType(EquipmentTypeData d) : base(d) { }
        public double AmountAvailable => Data?.AmountAvailable ?? UnspecifiedInteger;
    }
}
