using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Other {

    public sealed class EquipmentView : DefinedView {
        [DisplayName("Amount Available")]
        public int AmountAvailable { get; set; }
        [DisplayName("Amount In Using")]
        public int AmountInUsing { get; set; }
    }
}