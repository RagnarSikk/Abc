using Abc.Facade.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Facade.Others {
    public sealed class EquipmentForPersonView : UniqueEntityView {
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Equipment")] public string EquipmentId { get; set; }
    }
}
