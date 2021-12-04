using Abc.Facade.Common;

namespace Abc.Facade.Others {
    public sealed class ServiceView : UniqueEntityView {
        public string ServiceProviderRoleId { get; set; }
        public string ServiceTypeId { get; set; }
    }
}
