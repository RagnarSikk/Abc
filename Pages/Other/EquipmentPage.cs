using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Pages.Common;
using System;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others.Factories;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Abc.Domain.People.Repositories;
using Abc.Domain.People;
using Abc.Data.People;

namespace Abc.Pages.Other {
    public sealed class EquipmentPage : ViewPage<EquipmentPage, IEquipmentRepository, Equipment, EquipmentView, EquipmentData> {

        public IEnumerable<SelectListItem> EquipmentTypes { get; }
        public IEnumerable<SelectListItem> PersonRoleTypes { get; }

        public EquipmentPage(IEquipmentRepository r, IEquipmentTypeRepository b, IPersonRoleTypeRepository c)
            : base(r, "Equipments") {
            EquipmentTypes = newItemsList<EquipmentType, EquipmentTypeData>(b);
            PersonRoleTypes = newItemsList<PersonRoleType, PersonRoleTypeData>(c);
        }
        public string PersonRoleTypeName(string id) => itemName(PersonRoleTypes, id);
        public string EquipmentTypeName(string id) => itemName(EquipmentTypes, id);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.PersonRoleTypeId);
            createColumn(x => Item.EquipmentTypeId);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }

        public override string GetName(IHtmlHelper<EquipmentPage> h, int i) => i switch {
            3 or 4 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<EquipmentPage> h, int i) => i switch {
            1 => getRaw(h, PersonRoleTypeName(Item.PersonRoleTypeId)),
            2 => getRaw(h, EquipmentTypeName(Item.EquipmentTypeId)),
            3 or 4 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };

        protected internal override Uri pageUrl() => new Uri("/AdminView/Equipments", UriKind.Relative);
        protected internal override Equipment toObject(EquipmentView v) => new EquipmentViewFactory().Create(v);

        protected internal override EquipmentView toView(Equipment o) => new EquipmentViewFactory().Create(o);
        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new EquipmentView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
