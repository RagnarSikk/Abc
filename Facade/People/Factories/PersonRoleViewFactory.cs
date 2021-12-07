using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;

namespace Abc.Facade.People.Factories {
    public sealed class PersonRoleViewFactory : AbstractViewFactory<PersonRoleData, PersonRole, PersonRoleView> {
        protected internal override PersonRole toObject(PersonRoleData d) => new(d);
    }
}
