using Abc.Facade.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Facade.Others {
    public sealed class EquipmentTypeView : DefinedView {
        [DisplayName("Amount Available")] public string AmountAvailable { get; set; }
    }
}
