using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others;
using Abc.Pages.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages.Common {

    [TestClass]
    public class PagedPageTests
        : AbstractTests<CrudPage<IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData>> {
        private class testClass :
            PagedPage<IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData> {
            public testClass(IBodyMetricRepository r) : base(r) { }
            protected override void setPageValues(string sortOrder, string searchString, in int? pageIndex) {
                throw new System.NotImplementedException();
            }
            protected override BodyMetric toObject(BodyMetricView v) {
                throw new System.NotImplementedException();
            }
            protected override BodyMetricView toView(BodyMetric o) {
                throw new System.NotImplementedException();
            }
        }
        protected override object createObject() => new testClass(MockRepos.BodyMetric());
    }

}
