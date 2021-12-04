using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq.Expressions;

namespace Abc.Pages.Other {
    public sealed class ServiceTypePage : ViewPage<ServiceTypePage, IServiceTypeRepository, ServiceType, ServiceTypeView, ServiceTypeData> {
        public ServiceTypePage(IServiceTypeRepository r) : base(r, "Service types") { }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Code);
            createColumn(x => Item.Definition);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<ServiceTypePage> html, int i) {
            if (i == 4 || i == 5)
                return html.DisplayNameFor(Columns[i] as Expression<Func<ServiceTypePage, DateTime?>>);
            return base.GetName(html, i);
        }
        public override IHtmlContent GetValue(IHtmlHelper<ServiceTypePage> html, int i) {
            if (i == 4 || i == 5)
                return html.DisplayFor(Columns[i] as Expression<Func<ServiceTypePage, DateTime?>>);
            return base.GetValue(html, i);
        }

        protected internal override Uri pageUrl() => new Uri("/AdminView/ServiceTypes", UriKind.Relative);
        protected internal override ServiceType toObject(ServiceTypeView v) => new ServiceTypeViewFactory().Create(v);

        protected internal override ServiceTypeView toView(ServiceType o) => new ServiceTypeViewFactory().Create(o);
        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new ServiceTypeView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
