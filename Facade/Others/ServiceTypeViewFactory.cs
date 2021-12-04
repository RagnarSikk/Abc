using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others {
    public class ServiceTypeViewFactory : AbstractViewFactory<ServiceTypeData, ServiceType, ServiceTypeView> {
        protected internal override ServiceType toObject(ServiceTypeData d) => new(d);
    }
}