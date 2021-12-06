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
    public sealed class ServicePage : ViewPage<ServicePage, IServiceRepository, Service, ServiceView, ServiceData> {
        public ServicePage(IServiceRepository r) : base(r, "Services") { }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.ServiceProviderRoleId);
            createColumn(x => Item.ServiceTypeId);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }

        public override string GetName(IHtmlHelper<ServicePage> h, int i) => i switch
        {
            3 or 4 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<ServicePage> h, int i) => i switch
        {
            3 or 4 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };

        protected internal override Uri pageUrl() => new Uri("/AdminView/Services", UriKind.Relative);
        protected internal override Service toObject(ServiceView v) => new ServiceViewFactory().Create(v);

        protected internal override ServiceView toView(Service o) => new ServiceViewFactory().Create(o);
        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new ServiceView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
