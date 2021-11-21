﻿using Abc.Data.People;
using Abc.Domain.Common;

namespace Abc.Domain.People {
    public class PersonRoleType : DefinedEntity<PersonRoleTypeData> {
        public PersonRoleType(PersonRoleTypeData d) : base(d) { }
    }
}
