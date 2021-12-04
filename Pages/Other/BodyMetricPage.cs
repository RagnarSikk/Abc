using System;
using System.Linq.Expressions;
using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Other {
    public sealed class BodyMetricPage : ViewPage<BodyMetricPage, IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData>
    {
        public BodyMetricPage(IBodyMetricRepository r) : base(r, "Body Metrics") { }

        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Height);
            createColumn(x => Item.Weight);
            createColumn(x => Item.PersonId);
            createColumn(x => Item.BodyMetricTypeId);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }

        public override string GetName(IHtmlHelper<BodyMetricPage> html, int i)
        {
            if (i == 5 || i == 6)
                return html.DisplayNameFor(Columns[i] as Expression<Func<BodyMetricPage, DateTime?>>);
            return base.GetName(html, i);
        }

        public override IHtmlContent GetValue(IHtmlHelper<BodyMetricPage> html, int i)
        {
            if (i == 5 || i == 6)
                return html.DisplayFor(Columns[i] as Expression<Func<BodyMetricPage, DateTime?>>);
            return base.GetValue(html, i);
        }

        protected internal override Uri pageUrl()=> new Uri("/AdminView/BodyMetrics", UriKind.Relative);

        protected internal override BodyMetric toObject(BodyMetricView v) => new BodyMetricViewFactory().Create(v);

        protected internal override BodyMetricView toView(BodyMetric o) => new BodyMetricViewFactory().Create(o);

        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate)
        {
            Item = new BodyMetricView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
