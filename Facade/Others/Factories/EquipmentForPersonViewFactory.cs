using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others.Factories {
    public sealed class EquipmentForPersonViewFactory : AbstractViewFactory<EquipmentForPersonData, EquipmentForPerson, EquipmentForPersonView> {
        protected internal override EquipmentForPerson toObject(EquipmentForPersonData d) => new(d);
    }
}
