using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others.Factories
{
    public class BrandViewFactory : AbstractViewFactory<BrandData, Brand, BrandView>
    {
        protected internal override Brand toObject(BrandData d) => new(d);


    }
}
