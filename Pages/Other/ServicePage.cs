using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Abc.Data.People;
using Abc.Domain.People;

namespace Abc.Pages.Other {
    public sealed class ServicePage : ViewPage<ServicePage, IServiceRepository, Service, ServiceView, ServiceData> {
        
        public IEnumerable<SelectListItem> ServiceTypes { get; }
        public IEnumerable<SelectListItem> PersonRoleTypes { get; }

        public ServicePage(IServiceRepository r,IServiceTypeRepository b, IPersonRoleTypeRepository c)
            : base(r, "Services")
        {
            ServiceTypes = newItemsList<ServiceType, ServiceTypeData>(b);
            PersonRoleTypes = newItemsList<PersonRoleType, PersonRoleTypeData>(c);
        }
        public string PersonRoleTypeName(string id) => itemName(PersonRoleTypes, id);
        public string ServiceTypeName(string id) => itemName(ServiceTypes, id);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.PersonRoleTypeId);
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
            1 => getRaw(h, PersonRoleTypeName(Item.PersonRoleTypeId)),
            2 => getRaw(h, ServiceTypeName(Item.ServiceTypeId)),
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
