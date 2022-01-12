using Abc.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Others {
    public sealed class EquipmentTypeView : DefinedView {

        [DisplayName("Amount Available")] public string AmountAvailable { get; set; }
    }
}
