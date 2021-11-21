using Abc.Domain.People;

namespace Abc.Pages.People {
    public sealed class PersonBasePage : PersonAdminPage<PersonBasePage> {
        public PersonBasePage(IPersonRepository r) : base(r) { }
    }
}

