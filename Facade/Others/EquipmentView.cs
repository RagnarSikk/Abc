using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Others {

    public sealed class EquipmentView : DefinedView {
        [DisplayName("Amount")] public string Amount { get; set; }
        [DisplayName("Equipment Provider?")] public string PersonRoleTypeId { get; set; }
        [DisplayName("Equipment Type")] public string EquipmentTypeId { get; set; }
    }
}