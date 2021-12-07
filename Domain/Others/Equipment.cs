using Abc.Data.Others;
using Abc.Domain.Common;

namespace Abc.Domain.Others {
    public sealed class Equipment : UniqueEntity<EquipmentData> {
        public Equipment(EquipmentData d) : base(d) { }

        public int AmountAvailable => Data?.AmountAvailable ?? UnspecifiedInteger;
        public int AmountInUsing => Data?.AmountInUsing ?? UnspecifiedInteger;

    }

}
