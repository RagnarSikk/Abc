using Abc.Domain.Others.Repositories;

namespace Abc.Pages.Others {
    public sealed class EquipmentForBasePage : EquipmentForPersonPage<EquipmentForBasePage> {
        public EquipmentForBasePage(IEquipmentForPersonRepository r) : base(r) { }
    }
}
