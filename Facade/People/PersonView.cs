using Abc.Facade.Common;
using System;
using System.ComponentModel;

namespace Abc.Facade.People {
    public sealed class PersonView : UniqueEntityView {
        [DisplayName("Last Name")] public string LastName { get; set; }
        [DisplayName("First Middle Name")] public string FirstMidName { get; set; }
        [DisplayName("Phone Number")] public string PhoneNumber { get; set; }
        [DisplayName("Email")] public string Email { get; set; }
        [DisplayName("Gender")] public string Gender { get; set; }
        [DisplayName("Date of Birth")] public DateTime? DateOfBirth { get; set; }
    }
}
