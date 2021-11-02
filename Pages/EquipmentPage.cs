using Abc.Data.Others;
using Abc.Infra;

namespace Abc.Pages {
    public class EquipmentPage : AbstractPage<EquipmentPage, EquipmentData> {
        public EquipmentPage(TrainingDbContext c) : base(c, c.Equipments) {
            Caption = "Equipments";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.AmountAvailable);
            createColumn(x => Item.AmountInUsing);
        }
    }
}
