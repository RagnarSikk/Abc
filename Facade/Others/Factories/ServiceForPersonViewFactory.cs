using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Facade.Others.Factories {
    public class ServiceForPersonViewFactory : AbstractViewFactory<ServiceForPersonData, ServiceForPerson, ServiceForPersonView> {
        protected internal override ServiceForPerson toObject(ServiceForPersonData d) => new(d);
    }
}
