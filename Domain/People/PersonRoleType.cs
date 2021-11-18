using Abc.Domain.Common;
using Abc.Data.People;

namespace Abc.Domain.People
{
    public  class PersonRoleType : DefinedEntity<PersonRoleTypeData>
    {
        public PersonRoleType(PersonRoleTypeData d) : base(d) { }
    }
}
