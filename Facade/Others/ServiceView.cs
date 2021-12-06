using System.ComponentModel;
using Abc.Facade.Common;

namespace Abc.Facade.Others {
    public sealed class ServiceView : UniqueEntityView {
        [DisplayName("Service Provider")] public string PersonRoleTypeId { get; set; }
        [DisplayName("Service Type")]public string ServiceTypeId { get; set; }
    }
}
