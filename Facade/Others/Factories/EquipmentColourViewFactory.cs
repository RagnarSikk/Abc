using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others.Factories {
    public sealed class EquipmentColourViewFactory : AbstractViewFactory<EquipmentColourData, EquipmentColour, EquipmentColourView> {
        protected internal override EquipmentColour toObject(EquipmentColourData d) => new(d);


    }
}
