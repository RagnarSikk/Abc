using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others.Factories {
    public sealed  class EquipmentTypeViewFactory : AbstractViewFactory<EquipmentTypeData, EquipmentType, EquipmentTypeView> {
        protected internal override EquipmentType toObject(EquipmentTypeData d) => new(d);
    }
}
