using Abc.Data.People;
using Abc.Domain.Customers;
using Abc.Domain.People;
using Abc.Facade.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Facade.People
{
    public class AdministratorViewFactory : AbstractViewFactory<AdministratorData, Administrator, AdministratorView>
    {
        protected internal override Administrator toObject(AdministratorData d) => new Administrator(d);
    }
}
