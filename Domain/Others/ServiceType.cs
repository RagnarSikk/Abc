using Abc.Data.Others;
using Abc.Domain.Common;

namespace Abc.Domain.Others {
    public class ServiceType : DefinedEntity<ServiceTypeData> {
        public ServiceType(ServiceTypeData d) : base(d) { }
    }
}
