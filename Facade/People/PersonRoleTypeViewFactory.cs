using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;

namespace Abc.Facade.People {
    public class PersonRoleTypeViewFactory : AbstractViewFactory<PersonRoleTypeData, PersonRoleType, PersonRoleTypeView> {
        protected internal override PersonRoleType toObject(PersonRoleTypeData d) => new(d);
    }
}
