using Abc.Data.People;
using Abc.Infra;

namespace Abc.Pages {
    public class CoachPage : AbstractPage<CoachPage, CoachData> {
        public CoachPage(TrainingDbContext c) : base(c, c.Coaches) {
            Caption = "Coaches";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
        }
    }
}
