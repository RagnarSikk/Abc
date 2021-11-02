using Abc.Data.People;
using Abc.Infra;

namespace Abc.Pages {
    public class PhysiotherapistPage : AbstractPage<PhysiotherapistPage, PhysiotherapistData> {
        public PhysiotherapistPage(TrainingDbContext c) : base(c, c.Physiotherapists) {
            Caption = "Physiotherapist";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);

        }
    }
}
