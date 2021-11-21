using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;

namespace Abc.Facade.People {
    public class PersonViewFactory : AbstractViewFactory<PersonData, Person, PersonView> {
        protected internal override Person toObject(PersonData d) => new(d);
    }
}
