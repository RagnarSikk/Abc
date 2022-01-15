using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others.Repositories;

namespace Abc.Domain.Others {
    public sealed class EquipmentType : DefinedEntity<EquipmentTypeData> {
        public EquipmentType(EquipmentTypeData d) : base(d) { }
        public int AmountAvailable => Data?.AmountAvailable ?? UnspecifiedInteger;
        public string BrandId => Data?.BrandId ?? Unspecified;
        public Brand Brand => new GetFrom<IBrandRepository, Brand>().ById(BrandId);
        
        //public override string ToString() => $"{Name} ({Brand?.Name ?? Unspecified})";
    }
}
