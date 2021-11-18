using Abc.Data.Common;
using System;

namespace Abc.Domain.Common {
    public abstract class Person<TData> : UniqueEntity<TData>, IPersonEntity
        where TData : PersonData, new() {
        protected Person() : this(null) { }
        protected Person(TData d) : base(d) { }
        public string FirstMidName => Data?.FirstMidName ?? Unspecified;
        public string LastName => Data?.LastName ?? Unspecified;
        public string FullName {
            get {
                return LastName + ", " + FirstMidName;
            }
        }
        public string PhoneNumber => Data?.PhoneNumber ?? Unspecified;
        public string Email => Data?.Email ?? Unspecified;
        public string Gender => Data?.Gender ?? Unspecified;
        public DateTime DateOfBirth => Data?.DateOfBirth ?? UnspecifiedValidFrom; // ei ole kindel kas nii on ok?
    }
}
