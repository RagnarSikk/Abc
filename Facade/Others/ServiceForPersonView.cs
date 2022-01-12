using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Others {
    public sealed class ServiceForPersonView : UniqueEntityView {
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Service")] public string ServiceId { get; set; }
    }
}
