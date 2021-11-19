using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Domain.People;
using Microsoft.AspNetCore.Authorization;

namespace Abc.Pages.People
{
    public sealed class PersonBasePage : PersonAdminPage<PersonBasePage>
    {
        public PersonBasePage(IPersonRepository r) : base(r) { }
    }
}

