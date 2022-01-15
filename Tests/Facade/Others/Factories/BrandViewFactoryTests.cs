using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories
{
    [TestClass]
    public class BrandViewFactoryTests : FactoryBaseTests<BrandViewFactory, BrandData, Brand, BrandView>
    {
        protected override Brand createObject(BrandData d) => new(d);

       
    }
}
