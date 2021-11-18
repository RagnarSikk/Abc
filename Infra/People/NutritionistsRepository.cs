using Abc.Data.People;
using Abc.Domain.People;
using Abc.Infra.Common;

namespace Abc.Infra.People {
    public sealed class NutritionistsRepository : UniqueEntitiesRepository<Nutritionist, NutritionistData>, INutritionistsRepository {
        public NutritionistsRepository(TrainingDbContext c) : base(c, c.Nutritionists) { }
        protected internal override Nutritionist toDomainObject(NutritionistData d) => new Nutritionist(d);
    }
}
