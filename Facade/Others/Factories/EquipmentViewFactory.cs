using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others.Factories {
    public sealed class EquipmentViewFactory : AbstractViewFactory<EquipmentData, Equipment, EquipmentView> {
        protected internal override Equipment toObject(EquipmentData d) => new Equipment(d);
    }
}
