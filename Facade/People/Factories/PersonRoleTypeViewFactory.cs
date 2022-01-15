using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;

namespace Abc.Facade.People.Factories {
    public sealed class PersonRoleTypeViewFactory : AbstractViewFactory<PersonRoleTypeData, PersonRoleType, PersonRoleTypeView> {
        protected internal override PersonRoleType toObject(PersonRoleTypeData d) => new(d);
    }
}
