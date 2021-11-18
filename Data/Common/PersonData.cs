using System;

namespace Abc.Data.Common {
    public abstract class PersonData : UniqueEntityData {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }


    }
}
