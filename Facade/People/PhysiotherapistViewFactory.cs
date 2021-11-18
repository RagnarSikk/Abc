using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;

namespace Abc.Facade.People {
    public class PhysiotherapistViewFactory : AbstractViewFactory<PhysiotherapistData, Physiotherapist, PhysiotherapistView> {
        protected internal override Physiotherapist toObject(PhysiotherapistData d) => new Physiotherapist(d);
    }
}
