using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Others {
    public sealed class ServiceForPersonView : NamedView {
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Service")] public string ServiceId { get; set; }
    }
}
