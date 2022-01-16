//using Abc.Data.Others;
//using Abc.Domain.Others;
//using Abc.Domain.Others.Repositories;
//using Abc.Facade.Others;
//using Abc.Pages.Common;
//using Abc.Pages.Others;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;

//namespace Abc.Tests.Pages.Others
//{
//    [TestClass]
//    public class BrandBasePageTests
//        : CommonPageTests<BrandPage, ViewPage<BrandPage,
//        IBrandRepository, Brand, BrandView, BrandData>>
//    {

//        protected override object createObject()
//            => new BrandPage(MockRepos.Brand());
//        protected override string expectedUrl => "/Shop/Brand";

//        //public abstract class BrandsBasePageTests<TPage> :
//        //ViewPage<TPage, IBrandsRepository, Brand, BrandView, BrandData> 
//        //where TPage: PageModel{
//        //protected BrandsBasePageTests(IBrandsRepository r) : base(r, "Brands") { }
//        //protected internal override Uri pageUrl() => new Uri("/Shop/Brands", UriKind.Relative);
//        //protected internal override Brand toObject(BrandView v) => new BrandViewFactory().Create(v);
//        //protected internal override BrandView toView(Brand o) => new BrandViewFactory().Create(o);
//        protected override List<string> expectedIndexPageColumns => new()
//        {
//            "Id",
//            "Name",
//            "Code",
//            "From",
//            "To"
//        };
//        //public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch {
//        //    3 or 4 => getValue<DateTime?>(h, i),
//        //    _ => base.GetValue(h, i)
//        //};
//    }
//}
