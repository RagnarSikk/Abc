using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Pages.Common;
using System;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others.Factories;

namespace Abc.Pages {
    public class EquipmentPage : ViewPage<EquipmentPage, IEquipmentRepository, Equipment, EquipmentView, EquipmentData> {
        public EquipmentPage(IEquipmentRepository r) : base(r, "Equipments") { }
        protected internal override Uri pageUrl() => new Uri("/AdminView/Equipments", UriKind.Relative);
        protected internal override Equipment toObject(EquipmentView v) => new EquipmentViewFactory().Create(v);
        protected internal override EquipmentView toView(Equipment o) => new EquipmentViewFactory().Create(o);


        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Definition);
            createColumn(x => Item.AmountAvailable);
            createColumn(x => Item.AmountInUsing);
        }
    }
}
