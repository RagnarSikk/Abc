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
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Abc.Pages.Others {
    
   public abstract class EquipmentForPersonPage<TPage>
        : ViewPage<TPage, IEquipmentForPersonRepository, EquipmentForPerson, EquipmentForPersonView, EquipmentForPersonData>
        where TPage : PageModel {

        public IEnumerable<SelectListItem> EquipmentTypes { get; }
        public IEnumerable<SelectListItem> Persons { get; }
        protected EquipmentForPersonPage(IEquipmentForPersonRepository r) : base(r, "Equipments For Person") { }

        //protected EquipmentForPersonPage(IEquipmentForPersonRepository r, IEquipmentForPersonRepository b) : base(r, "Equipments For Person") { }

        public EquipmentForPersonPage(IEquipmentForPersonRepository r, IEquipmentTypeRepository b, IPersonRepository c)
            : base(r, "Equipments For Person") {
            EquipmentTypes = newItemsList<EquipmentType, EquipmentTypeData>(b, null, x => x.Name);
            Persons = newItemsList<Person, PersonData>(c, null, x => x.FirstMidName + " " + x.LastName);
        }

        public string PersonName(string id) => itemName(Persons, id);
        public string EquipmentTypeName(string id) => itemName(EquipmentTypes, id);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.PersonId);
            createColumn(x => Item.EquipmentId);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }

        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch {
            3 or 4 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch {
            1 => getRaw(h, PersonName(Item.PersonId)),
            2 => getRaw(h, EquipmentTypeName(Item.EquipmentId)),
            3 or 4 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };

        protected internal override Uri pageUrl() => new Uri("/AdminView/EquipmentForPerson", UriKind.Relative);
        protected internal override EquipmentForPerson toObject(EquipmentForPersonView v) => new EquipmentForPersonViewFactory().Create(v);

        protected internal override EquipmentForPersonView toView(EquipmentForPerson o) => new EquipmentForPersonViewFactory().Create(o);
        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new EquipmentForPersonView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
