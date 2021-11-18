using System;
using System.ComponentModel;

namespace Abc.Facade.Common {
    public abstract class PersonView : UniqueEntityView {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [DisplayName("Full Name")]
        public string FullName => LastName + " " + FirstMidName;
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
    }
}
