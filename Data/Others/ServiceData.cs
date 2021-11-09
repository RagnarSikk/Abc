using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Data.Common;

namespace Abc.Data.Others
{
    public class ServiceData : UniqueEntityData
    {
        public string ServiceProviderId { get; set; }
        public string AthleteId { get; set; }
    }
}
