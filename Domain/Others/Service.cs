using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Data.Others;
using Abc.Domain.Common;

namespace Abc.Domain.Others
{
    public sealed class Service : UniqueEntity<ServiceData>
    {
        public Service(ServiceData d) : base(d) { }
        public string ServiceProviderId => Data.ServiceProviderId ?? Unspecified;
        public string AthleteId => Data.AthleteId ?? Unspecified;

    }
}
