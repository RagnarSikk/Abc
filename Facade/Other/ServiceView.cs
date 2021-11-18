
using Abc.Facade.Common;

namespace Abc.Facade.Other {
    public sealed class ServiceView : UniqueEntityView {
        public string ServiceProviderRoleId { get; set; }
        public string ServiceTypeId { get; set; }
    }
}
