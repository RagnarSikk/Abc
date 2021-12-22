using Abc.Data.Others;
using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Domain.Others {
    public sealed class EquipmentType : DefinedEntity<EquipmentTypeData> {
        public EquipmentType(EquipmentTypeData d) : base(d) { }
        public double AmountAvailable => Data?.AmountAvailable ?? UnspecifiedInteger;
    }
}
