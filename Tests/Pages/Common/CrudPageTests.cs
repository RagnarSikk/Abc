using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others;
using Abc.Pages.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages.Common {

    [TestClass]
    public class CrudPageTests
        : AbstractTests<BasePage<IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData>> {
        private class testClass :
            CrudPage<IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData> {
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
        //public abstract class CrudPageTests<TRepository, TDomain, TView, TData> :
        //BasePageTests<TRepository, TDomain, TView, TData>
        //where TRepository : class, ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
        //where TView : PeriodView {

        //protected CrudPageTests(TRepository r) : base(r) { }

        //[BindProperty]
        //public TView Item { get; set; }
        //public string ItemId => Item?.GetId() ?? string.Empty;

        //protected internal async Task<bool> addObject(string fixedFilter, string fixedValue) {
        //    setFixedFilter(fixedFilter, fixedValue);
        //    if (!ModelState.IsValid) return false;
        //    await db.Add(toObject(Item)).ConfigureAwait(true);
        //    return true;
        //}
        //protected internal async Task<bool> addObject(string sortOrder, string searchString, int? pageIndex, string fixedFilter, string fixedValue) {
        //    setPageValues(sortOrder, searchString, pageIndex);
        //    return await addObject(fixedFilter, fixedValue).ConfigureAwait(true);
        //}

        //protected internal async Task<bool> updateObject(string fixedFilter, string fixedValue) {
        //    setFixedFilter(fixedFilter, fixedValue);

        //    if (!ModelState.IsValid) return false;
        //    await db.Update(toObject(Item)).ConfigureAwait(true);

        //    return true;
        //}

        //protected internal async Task<bool> updateObject(string sortOrder, string searchString, int? pageIndex, string fixedFilter, string fixedValue) {
        //    setPageValues(sortOrder, searchString, pageIndex);
        //    return await updateObject(fixedFilter, fixedValue).ConfigureAwait(true);
        //}

        //protected internal async Task getObject(string id, string fixedFilter, string fixedValue) {
        //    setFixedFilter(fixedFilter, fixedValue);
        //    var o = await db.Get(id).ConfigureAwait(true);
        //    Item = toView(o);
        //}

        //protected internal async Task getObject(string id, string sortOrder, string searchString, int? pageIndex, string fixedFilter, string fixedValue) {
        //    setPageValues(sortOrder, searchString, pageIndex);
        //    await getObject(id, fixedFilter, fixedValue).ConfigureAwait(true);
        //}

        //protected internal async Task deleteObject(string id, string fixedFilter, string fixedValue) {
        //    setFixedFilter(fixedFilter, fixedValue);
        //    await db.Delete(id).ConfigureAwait(true);
        //}

        //protected internal async Task deleteObject(string id, string sortOrder, string searchString, int? pageIndex,
        //    string fixedFilter, string fixedValue) {
        //    setPageValues(sortOrder, searchString, pageIndex);
        //    await deleteObject(id, fixedFilter, fixedValue).ConfigureAwait(true);
        //}

        //protected internal abstract TDomain toObject(TView v);

        //protected internal abstract TView toView(TDomain o);

    }

}
