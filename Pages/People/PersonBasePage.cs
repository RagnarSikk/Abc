using Abc.Domain.People.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace Abc.Pages.People {
    [Authorize]
    public sealed class PersonBasePage : PersonAdminPage<PersonBasePage> {
        public PersonBasePage(IPersonRepository r) : base(r) { }
    }
}

