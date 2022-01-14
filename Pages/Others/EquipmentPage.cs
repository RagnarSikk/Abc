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
            3 => getName<int>(h,i),
            4 or 5 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<EquipmentPage> h, int i) => i switch {
            1 => getRaw(h, PersonRoleTypeName(Item.PersonRoleTypeId)),
            2 => getRaw(h, EquipmentTypeName(Item.EquipmentTypeId)),
            3 => getValue<int>(h,i),
            4 or 5 => getValue<DateTime?>(h, i),
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
