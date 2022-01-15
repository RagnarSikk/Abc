using Abc.Data.People;
using Abc.Domain.Common;
using System;

namespace Abc.Domain.People {
    public sealed class Person : UniqueEntity<PersonData> {
        public Person(PersonData d) : base(d) { }
        public string FirstMidName => Data?.FirstMidName ?? Unspecified;
        public string LastName => Data?.LastName ?? Unspecified;
        public string PhoneNumber => Data?.PhoneNumber ?? Unspecified;
        public string Email => Data?.Email ?? Unspecified;
        public string Gender => Data?.Gender ?? Unspecified;
        public DateTime DateOfBirth => Data?.DateOfBirth ?? UnspecifiedValidFrom; // ei ole kindel kas nii on ok?

    }
}
