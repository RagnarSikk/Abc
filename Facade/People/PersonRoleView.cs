﻿using System.ComponentModel;
using Abc.Facade.Common;

namespace Abc.Facade.People {
    public sealed class PersonRoleView : UniqueEntityView {
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Role Type")]public string PersonRoleTypeId { get; set; }
        [DisplayName("Certificate")] public string Certificate { get; set; }
    }
}
