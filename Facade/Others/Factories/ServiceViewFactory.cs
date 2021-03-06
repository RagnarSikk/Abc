using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others.Factories {
    public sealed class ServiceViewFactory : AbstractViewFactory<ServiceData, Service, ServiceView> {
        protected internal override Service toObject(ServiceData d) => new(d);
    }
}