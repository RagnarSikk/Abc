using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Other;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Other
{
    public sealed class ServicePage : ViewPage<ServicePage, IServiceRepository, Service, ServiceView, ServiceData>
    {
        public ServicePage(IServiceRepository r) : base(r, "Services") { }

        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.ServiceProviderRoleId);
            createColumn(x => Item.ServiceTypeId);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<ServicePage> html, int i)
        {
            if (i == 3 || i == 4)
                return html.DisplayNameFor(Columns[i] as Expression<Func<ServicePage, DateTime?>>);
            return base.GetName(html, i);
        }
        public override IHtmlContent GetValue(IHtmlHelper<ServicePage> html, int i)
        {
            if (i == 3 || i == 4)
                return html.DisplayFor(Columns[i] as Expression<Func<ServicePage, DateTime?>>);
            return base.GetValue(html, i);
        }

        protected internal override Uri pageUrl() => new Uri("/AdminView/Services", UriKind.Relative);
        protected internal override Service toObject(ServiceView v) => new ServiceViewFactory().Create(v);

        protected internal override ServiceView toView(Service o) => new ServiceViewFactory().Create(o);
        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate)
        {
            Item = new ServiceView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
