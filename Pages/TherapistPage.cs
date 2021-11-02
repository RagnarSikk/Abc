using Abc.Data.People;
using Abc.Infra;

namespace Abc.Pages {
    public class TherapistPage : AbstractPage<TherapistPage, TherapistData> {
        public TherapistPage(TrainingDbContext c) : base(c, c.Therapists) {
            Caption = "Therapist";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);

        }
    }
}
