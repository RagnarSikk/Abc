using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others.Factories {
    public sealed class ServiceForPersonViewFactory : AbstractViewFactory<ServiceForPersonData, ServiceForPerson, ServiceForPersonView> {
        protected internal override ServiceForPerson toObject(ServiceForPersonData d) => new(d);
    }
}
