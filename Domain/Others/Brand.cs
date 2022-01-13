using Abc.Data.Others;
using Abc.Domain.Common;

namespace Abc.Domain.Others {
    public sealed class Brand : DefinedEntity<BrandData> {
        public Brand(BrandData d) : base(d) { }
    }
}