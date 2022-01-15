using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Others {
    public sealed class EquipmentTypeView : DefinedView {

        [DisplayName("Amount Available")] public string AmountAvailable { get; set; }
        [DisplayName("Brand")] public string BrandId { get; set; }
    }
}
