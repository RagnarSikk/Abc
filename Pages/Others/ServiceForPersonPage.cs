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

namespace Abc.Pages.Others {
    public sealed class ServiceForPersonPage : ViewPage<ServiceForPersonPage, IServiceForPersonRepository, ServiceForPerson, ServiceForPersonView, ServiceForPersonData> {

        public IEnumerable<SelectListItem> ServiceTypes { get; }
        public IEnumerable<SelectListItem> Persons { get; }

        public ServiceForPersonPage(IServiceForPersonRepository r, IServiceTypeRepository b, IPersonRepository c)
            : base(r, "Services For Person") {
            ServiceTypes = newItemsList<ServiceType, ServiceTypeData>(b, null, x => x.Name);
            Persons = newItemsList<Person, PersonData>(c, null, x => x.FirstMidName + " " + x.LastName);
        }
        public string PersonName(string id) => itemName(Persons, id);
        public string ServiceTypeName(string id) => itemName(ServiceTypes, id);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            //createColumn(x => Item.Name);
            createColumn(x => Item.PersonId);
            createColumn(x => Item.ServiceId);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }

        public override string GetName(IHtmlHelper<ServiceForPersonPage> h, int i) => i switch {
            4 or 5 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<ServiceForPersonPage> h, int i) => i switch {
            2 => getRaw(h, PersonName(Item.PersonId)),
            3 => getRaw(h, ServiceTypeName(Item.ServiceId)),
            4 or 5 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };

        protected internal override Uri pageUrl() => new Uri("/AdminView/ServiceForPerson", UriKind.Relative);
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
