using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Facade.Common;

namespace Abc.Facade.People
{
    public class PersonRoleView: UniqueEntityView
    {
        public string PersonId { get; set; }
        public string PersonRoleTypeId { get; set; }
        public string Certificate { get; set; }
    }
}
