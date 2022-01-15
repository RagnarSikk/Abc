using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Others {
    public sealed class EquipmentTypeView : DefinedView {

        [DisplayName("Amount Available")] public int AmountAvailable { get; set; }
    }
}
