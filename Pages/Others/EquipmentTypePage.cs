using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Abc.Pages.Others {
    public sealed class EquipmentTypePage : ViewPage<EquipmentTypePage, IEquipmentTypeRepository, EquipmentType, EquipmentTypeView, EquipmentTypeData> {
        public EquipmentTypePage(IEquipmentTypeRepository r) : base(r, "Equipment types") { }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Code);
            createColumn(x => Item.Definition);
            createColumn(x => Item.AmountAvailable);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<EquipmentTypePage> h, int i) => i switch {
            5 or 6 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<EquipmentTypePage> h, int i) => i switch {
            5 or 6 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };

        protected internal override Uri pageUrl() => new Uri("/AdminView/EquipmentTypes", UriKind.Relative);
        protected internal override EquipmentType toObject(EquipmentTypeView v) => new EquipmentTypeViewFactory().Create(v);

        protected internal override EquipmentTypeView toView(EquipmentType o) => new EquipmentTypeViewFactory().Create(o);
        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new EquipmentTypeView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
