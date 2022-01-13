using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages.Common {

    [TestClass]
    public class BasePageTests : AbstractTests<PageModel> {
        private class testClass :
            BasePage<IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData> {
            public testClass(IBodyMetricRepository r) : base(r) { }
            protected override void setPageValues(string sortOrder, string searchString, in int? pageIndex) {
                throw new System.NotImplementedException();
            }
        }
        protected override object createObject() => new testClass(MockRepos.BodyMetric());

    }
}
