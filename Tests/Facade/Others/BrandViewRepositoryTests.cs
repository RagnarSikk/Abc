using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Tests.Facade.Others
{
    [TestClass]
    public class BrandViewFactoryTests : FactoryBaseTests<BrandViewFactory, BrandData, Brand, BrandView>
    {
        protected override Brand createObject(BrandData d) => new(d);
    }
}
