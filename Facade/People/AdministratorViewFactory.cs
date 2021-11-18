using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;

namespace Abc.Facade.People {
    public class AdministratorViewFactory : AbstractViewFactory<AdministratorData, Administrator, AdministratorView> {
        protected internal override Administrator toObject(AdministratorData d) => new Administrator(d);
    }
}
