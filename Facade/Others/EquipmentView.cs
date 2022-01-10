using Abc.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Others {

    public sealed class EquipmentView : DefinedView {
        [Range(0, 100)] [DisplayName("Amount")] public string Amount { get; set; }
        [DisplayName("Equipment Provider")] public string PersonRoleTypeId { get; set; }
        [DisplayName("Equipment Type")] public string EquipmentTypeId { get; set; }
    }
}