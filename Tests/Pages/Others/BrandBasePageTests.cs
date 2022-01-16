//using System;
//using System.Collections.Generic;
//using Abc.Data.Others;
//using Abc.Domain.Others;
//using Abc.Domain.Others.Repositories;
//using Abc.Facade.Others;
//using Abc.Facade.Others.Factories;
//using Abc.Pages.Common;
//using Abc.Pages.Others;
//using Microsoft.AspNetCore.Html;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Abc.Tests.Pages.Others {


//    [TestClass]
//    public class BrandBasePageTests
//        : CommonPageTests<BrandPage, ViewPage<BrandPage,
//            IBrandRepository, Brand, BrandView, BrandData>>
//    {

//        protected override object createObject()
//            => new BrandPage(MockRepos.Brand());
//        protected override List<string> expectedIndexPageColumns => new()
//        {
//            "Id",
//            "Name",
//            "Code",
//            "From",
//            "To"
//        };
//    }



//    //public abstract class BrandBasePage<TPage> :

//    //    ViewPage<TPage, IBrandRepository, Brand, BrandView, BrandData>
//    //    where TPage : PageModel {
//    //    protected BrandBasePage(IBrandRepository r) : base(r, "Brand") { }

//    //    protected internal override Brand toObject(BrandView v) => new BrandViewFactory().Create(v);

//    //    protected internal override BrandView toView(Brand o) => new BrandViewFactory().Create(o);
//    //    protected override void createTableColumns() {
//    //        createColumn(x => Item.Id);
//    //        createColumn(x => Item.Name);
//    //        createColumn(x => Item.Code);
//    //        createColumn(x => Item.From);
//    //        createColumn(x => Item.To);
//    //    }

//    //    public override string GetName(IHtmlHelper<TPage> h, int i) => i switch {
//    //        3 or 4 => getName<DateTime?>(h, i),
//    //        _ => base.GetName(h, i)
//    //    };

//    //    public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch {
//    //        3 or 4 => getValue<DateTime?>(h, i),
//    //        _ => base.GetValue(h, i)
//    //    };
//    //    public override IActionResult OnGetCreate(
//    //        string sortOrder, string searchString, int? pageIndex,
//    //        string fixedFilter, string fixedValue, int? switchOfCreate) {
//    //        Item = new BrandView();
//    //        return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
//    //    }

//    //}
//}
