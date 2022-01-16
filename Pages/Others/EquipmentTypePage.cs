using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
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
    public sealed class EquipmentTypePage : ViewPage<EquipmentTypePage, IEquipmentTypeRepository, EquipmentType, EquipmentTypeView, EquipmentTypeData> {
        public IEnumerable<SelectListItem> Brands { get; }
        public IEnumerable<SelectListItem> EquipmentColours { get; }
        public EquipmentTypePage(IEquipmentTypeRepository r, IBrandRepository b, IEquipmentColourRepository c)
          : base(r, "EquipmentTypes") {
            Brands = newItemsList<Brand, BrandData>(b, null, x => x.Name);
            EquipmentColours = newItemsList<EquipmentColour, EquipmentColourData>(c, null, x => x.Name);
        }



        public string BrandName(string id) => itemName(Brands, id);
        public string EquipmentColourName(string id) => itemName(EquipmentColours, id);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Code);
            createColumn(x => Item.Definition);
            createColumn(x => Item.AmountAvailable);
            createColumn(x => Item.BrandId);
            createColumn(x => Item.EquipmentColourId);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<EquipmentTypePage> h, int i) => i switch {
            4 => getName<int>(h, i),
            //5 => getName<int>(h, i),
            7 or 8 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<EquipmentTypePage> h, int i) => i switch {
            4 => getValue<int>(h, i),
            5 => getRaw(h, BrandName(Item.BrandId)),
            6 => getRaw(h, EquipmentColourName(Item.EquipmentColourId)),
            7 or 8 => getValue<DateTime?>(h, i),
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
