using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Abc.Pages.Others {
    [Authorize]
    public sealed class EquipmentForPersonPage : ViewPage<EquipmentForPersonPage,
        IEquipmentForPersonRepository, EquipmentForPerson, EquipmentForPersonView, EquipmentForPersonData> {

        public IEnumerable<SelectListItem> EquipmentTypes { get; }
        public IEnumerable<SelectListItem> Persons { get; }
        public IEnumerable<SelectListItem> PersonRoleTypes { get; }

        public EquipmentForPersonPage(IEquipmentForPersonRepository r, IEquipmentTypeRepository b, IPersonRepository c, IPersonRoleTypeRepository d)
            : base(r, "Equipments For Person") {
            EquipmentTypes = newItemsList<EquipmentType, EquipmentTypeData>(b, null, x => x.Name);
            Persons = newItemsList<Person, PersonData>(c, null, x => x.FirstMidName + " " + x.LastName);
            PersonRoleTypes = newItemsList<PersonRoleType, PersonRoleTypeData>(d);
        }

        public string PersonName(string id) => itemName(Persons, id);
        public string PersonRoleName(string id) => itemName(PersonRoleTypes, id);
        public string EquipmentTypeName(string id) => itemName(EquipmentTypes, id);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.PersonId);
            createColumn(x => Item.PersonRoleTypeId);
            createColumn(x => Item.EquipmentId);
            createColumn(x => Item.Amount);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }

        public override string GetName(IHtmlHelper<EquipmentForPersonPage> h, int i) => i switch {
            4 => getName<int>(h, i),
            5 or 6 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<EquipmentForPersonPage> h, int i) => i switch {
            1 => getRaw(h, PersonName(Item.PersonId)),
            2 => getRaw(h, PersonRoleName(Item.PersonRoleTypeId)),
            3 => getRaw(h, EquipmentTypeName(Item.EquipmentId)),
            4 => getValue<int>(h, i),
            5 or 6 => getValue<DateTime?>(h, i),
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
