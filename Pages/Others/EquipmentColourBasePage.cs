using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Abc.Pages.Others
{
    public abstract class EquipmentColourBasePage<TPage> :
        
        ViewPage<TPage, IEquipmentColourRepository, EquipmentColour, EquipmentColourView, EquipmentColourData>
        where TPage: PageModel{
        protected EquipmentColourBasePage(IEquipmentColourRepository r) : base(r, "EquipmentColour") { }

        protected internal override EquipmentColour toObject(EquipmentColourView v) => new EquipmentColourViewFactory().Create(v);

        protected internal override EquipmentColourView toView(EquipmentColour o) => new EquipmentColourViewFactory().Create(o);
        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Code);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }

        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch {
            3 or 4 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch {
            3 or 4 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };

    }
}
