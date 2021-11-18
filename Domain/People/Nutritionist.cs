using Abc.Data.People;
using Abc.Domain.Common;

namespace Abc.Domain.People {
    public sealed class Nutritionist : Person<NutritionistData> {
        public Nutritionist(NutritionistData d) : base(d) { }

        public string ServiceProviderId => Data.ServiceProviderId ?? Unspecified;

    }
}
