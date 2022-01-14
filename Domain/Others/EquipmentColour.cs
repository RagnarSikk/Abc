using Abc.Data.Others;
using Abc.Domain.Common;

namespace Abc.Domain.Others {
    public sealed class EquipmentColour : NamedEntity<EquipmentColourData> {
        public EquipmentColour(EquipmentColourData d) : base(d) { }
    }
}