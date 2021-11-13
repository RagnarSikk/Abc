using Abc.Facade.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Facade.Other
{

    public sealed class EquipmentView : DefinedView
    {
        [DisplayName("Amount Available")]
        public int AmountAvailable { get; set; }
        [DisplayName("Amount In Using")]
        public int AmountInUsing { get; set; }
    }
}