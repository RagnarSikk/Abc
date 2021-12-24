using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Others {
    public sealed class ServiceView : UniqueEntityView {
        [DisplayName("Service Provider")] public string PersonRoleTypeId { get; set; }
        [DisplayName("Service Type")] public string ServiceTypeId { get; set; }
    }
}
