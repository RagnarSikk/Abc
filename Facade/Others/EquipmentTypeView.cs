using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Others {
    public sealed class EquipmentTypeView : DefinedView {

        [DisplayName("Amount Available")] public int AmountAvailable { get; set; }
        [DisplayName("Brand")] public string BrandId { get; set; }
        [DisplayName("Equipment Colour")] public string EquipmentColourId { get; set; }
    }
}
