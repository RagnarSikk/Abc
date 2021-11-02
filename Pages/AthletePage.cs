using Abc.Data.Customers;
using Abc.Infra;

namespace Abc.Pages {
    public class AthletePage : AbstractPage<AthletePage, AthleteData> {
        public AthletePage(TrainingDbContext c) : base(c, c.Athletes) {
            Caption = "Athletes";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Weight);
            createColumn(x => Item.Height);
            createColumn(x => Item.AmountOfVisits);
        }
    }
}
