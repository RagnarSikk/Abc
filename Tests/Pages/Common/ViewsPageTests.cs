using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others;
using Abc.Pages.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Pages.Common {
    public class MockViewsPage :
        ViewsPage<MockViewsPage, IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData> {
        public MockViewsPage(IBodyMetricRepository r) : base(r, nameof(BodyMetric) + "s") { }
        protected override void createTableColumns() {
            //throw new NotImplementedException();
        }
        protected override Uri pageUrl() {
            throw new NotImplementedException();
        }
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
    [TestClass]
    public class ViewsPageTests
        : AbstractTests<ViewPage<MockViewsPage, IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData>> {
        protected override object createObject() => new MockViewsPage(MockRepos.BodyMetric());

    }
}
