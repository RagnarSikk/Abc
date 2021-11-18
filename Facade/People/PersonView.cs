using System;
using System.ComponentModel;
using Abc.Facade.Common;

namespace Abc.Facade.People
{
    public class PersonView: UniqueEntityView
    {
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
    }
}
