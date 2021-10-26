using Abc.Data;
using Abc.Infra;

namespace Abc.Pages {
    public class AdministratorPage : AbstractPage<AdministratorPage, AdminstratorData> {
        public AdministratorPage(TrainingDbContext c) : base(c, c.Administrators) {
            Caption = "Administrators";
        }
        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.AdministartorId);
        }
    }
}
