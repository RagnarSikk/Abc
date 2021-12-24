using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.People {
    public sealed class PersonRoleView : UniqueEntityView {
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Role Type")] public string PersonRoleTypeId { get; set; }
        [DisplayName("Certificate")] public string Certificate { get; set; }
    }
}
