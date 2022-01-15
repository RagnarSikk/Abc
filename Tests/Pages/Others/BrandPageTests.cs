using Abc.Pages.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Abc.Tests.Pages.Shop
{
    [TestClass]
    public class BrandPageTests
        : AuthorizedPageTests<BrandPage, BrandBasePage<BrandPage>>
    {
        protected override object createObject() => new BrandPage(MockRepos.Brand());
        protected override string expectedUrl => "/Shop/Brands";
        protected override List<string> expectedIndexPageColumns
            => new() { "Id", "Name", "Code", "From", "To" };
    }
}
