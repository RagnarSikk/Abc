using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;

namespace Abc.Facade.People {
    public class TherapistViewFactory : AbstractViewFactory<TherapistData, Therapist, TherapistView> {
        protected internal override Therapist toObject(TherapistData d) => new Therapist(d);
    }
}
