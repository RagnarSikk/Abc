using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Others {
    public sealed class EquipmentForPersonData : UniqueEntityData {
        public string PersonId { get; set; }
        public string EquipmentId { get; set; }
    }
}
