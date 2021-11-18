using Abc.Data.Customers;
using Abc.Domain.Customers;
using Abc.Facade.Common;

namespace Abc.Facade.Customers {
    public class AthleteViewFactory : AbstractViewFactory<AthleteData, Athlete, AthleteView> {
        protected internal override Athlete toObject(AthleteData d) => new Athlete(d);
    }
}
