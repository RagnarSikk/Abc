using Abc.Domain.People;
using Abc.Domain.People.Repositories;

namespace Abc.Pages.People {
    public sealed class PersonBasePage : PersonAdminPage<PersonBasePage> {
        public PersonBasePage(IPersonRepository r) : base(r) { }
    }
}

