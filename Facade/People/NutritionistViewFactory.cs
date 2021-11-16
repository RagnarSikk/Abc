using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;

namespace Abc.Facade.People
{
    public class NutritionistViewFactory : AbstractViewFactory<NutritionistData, Nutritionist, NutritionistView>
    {
        protected internal override Nutritionist toObject(NutritionistData d) => new Nutritionist(d);
    }
}
