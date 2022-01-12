using Abc.Pages.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others;

namespace Abc.Tests.Pages.Common {
    [TestClass]
    public class UnifiedPageTests
        : AbstractTests<TitledPage<IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData>> {
        private class testClass :
            UnifiedPage<testClass, IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData> {
            public testClass(IBodyMetricRepository r) : base(r, nameof(BodyMetric) + "s") { }
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
        protected override object createObject() => new testClass(MockRepos.BodyMetric());
        //public abstract class UnifiedPageTests<TPage, TRepository, TDomain, TView, TData>
        //:TitledPageTests<TRepository, TDomain, TView, TData>, IIndexTable<TPage>
        //where TPage : PageModel
        //where TRepository : class, ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
        //where TView : PeriodView {

        //protected UnifiedPageTests(TRepository r, string title) : base(r, title) => createTableColumns();

        //protected abstract void createTableColumns();

        //public List<LambdaExpression> Columns { get; }
        //    = new List<LambdaExpression>();

        //protected void createColumn<TResult>(Expression<Func<TPage, TResult>> e) => Columns.Add(e);

        //public void SetItem(int i) {
        //    Item = null;
        //    if (isCorrectIndex(i, Items)) Item = Items[i];
        //}

        //private static bool isCorrectIndex<TList>(int i, IList<TList> l) => i >= 0 && i < l?.Count;

        //public virtual string GetName(IHtmlHelper<TPage> h, int i) => getName<string>(h, i);

        //protected string getName<TResult>(IHtmlHelper<TPage> h, int i) {
        //    if (isCorrectIndex(i, Columns))
        //        return h.DisplayNameFor(Columns[i] as Expression<Func<TPage, TResult>>);
        //    return Undefined;
        //}

        //public virtual IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => getValue<string>(h, i);

        //protected IHtmlContent getValue<TResult>(IHtmlHelper<TPage> h, int i) {
        //    if (isCorrectIndex(i, Columns))
        //        return h.DisplayFor(Columns[i] as Expression<Func<TPage, TResult>>);
        //    return null;
        //}
        //protected IHtmlContent getRaw<TResult>(IHtmlHelper<TPage> h, TResult r) => h.Raw(r.ToString());

        //public virtual Uri GetSortStringExpression(int i)
        //            => isCorrectIndex(i, Columns)
        //            ? GetSortString(toExpr<string>(Columns[i]), pageUrl())
        //            : null;

        //public Uri GetSortString<T>(Expression<Func<TPage, T>> e, Uri page) {
        //    var name = GetMember.Name(e);
        //    var sortOrder = getSortOrder(name);

        //    return new Uri(
        //        $"{page}?handler=Index&sortOrder={sortOrder}&currentFilter={CurrentFilter}&searchString={SearchString}"
        //        + $"&fixedFilter={FixedFilter}&fixedValue={FixedValue}", UriKind.Relative);
        //}

        //protected Expression<Func<TPage, TResult>> toExpr<TResult>(LambdaExpression e)
        //    => e as Expression<Func<TPage, TResult>>;


        //public int ColumnsCount => Columns?.Count ?? -1;

        //public int RowsCount => Items?.Count ?? -1;

        //public string Undefined => "Undefined";

    }
}