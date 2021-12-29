using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Others {
    public sealed class EquipmentForPersonView : NamedView {
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Equipment")] public string EquipmentId { get; set; }
    }
}
