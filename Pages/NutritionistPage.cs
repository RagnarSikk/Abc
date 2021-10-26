using Abc.Data;
using Abc.Infra;

namespace Abc.Pages {
    public class NutritionistPage : AbstractPage<NutritionistPage, NutritionistData> {
        public NutritionistPage(TrainingDbContext c) : base(c, c.Nutritionists) {
            Caption = "Nutritionists";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);

        }
    }
}
