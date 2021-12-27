using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Abc.Pages.Other {
    public sealed class ServiceForCustomerPage : ViewPage<ServiceForPersonPage, IServiceForPersonRepository, ServiceForPerson, ServiceForPersonView, ServiceForPersonData> {

        public IEnumerable<SelectListItem> ServiceTypes { get; }
        public IEnumerable<SelectListItem> Persons { get; }

        public ServiceForCustomerPage(IServiceForPersonRepository r, IServiceTypeRepository b, IPersonRepository c)
            : base(r, "Servicesn") {
            ServiceTypes = newItemsList<ServiceType, ServiceTypeData>(b, null, x => x.Name);
            Persons = newItemsList<Person, PersonData>(c, null, x => x.FirstMidName + " " + x.LastName);
        }
        public string PersonName(string id) => itemName(Persons, id);
        public string ServiceTypeName(string id) => itemName(ServiceTypes, id);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.PersonId);
            createColumn(x => Item.ServiceId);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }

        public override string GetName(IHtmlHelper<ServiceForPersonPage> h, int i) => i switch {
            3 or 4 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<ServiceForPersonPage> h, int i) => i switch {
            1 => getRaw(h, PersonName(Item.PersonId)),
            2 => getRaw(h, ServiceTypeName(Item.ServiceId)),
            3 or 4 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };

        protected internal override Uri pageUrl() => new Uri("/Customers/ServiceForPerson", UriKind.Relative);
        protected internal override ServiceForPerson toObject(ServiceForPersonView v) => new ServiceForPersonViewFactory().Create(v);

        protected internal override ServiceForPersonView toView(ServiceForPerson o) => new ServiceForPersonViewFactory().Create(o);
        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new ServiceForPersonView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
