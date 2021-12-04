using System.ComponentModel;
using Abc.Facade.Common;

namespace Abc.Facade.People {
    public sealed class PersonRoleView : UniqueEntityView {
        public string PersonId { get; set; }
        public string PersonRoleTypeId { get; set; }
        [DisplayName("Certificate")]public string Certificate { get; set; }
    }
}
