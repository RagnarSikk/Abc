using Abc.Data.Others;
using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Domain.Others
{
    public sealed class Equipment : DefinedEntity<EquipmentData>
    {
        public Equipment(EquipmentData d) : base(d) { }
        
        public int AmountAvailable => Data?.AmountAvailable ?? UnspecifiedInteger;
        public int AmountInUsing => Data?.AmountInUsing ?? UnspecifiedInteger;

    }
    
}
