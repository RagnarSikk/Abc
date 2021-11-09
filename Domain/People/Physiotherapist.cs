﻿using Abc.Data.People;
using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Domain.People
{
    public sealed class Physiotherapist : Person<PhysiotherapistData>
    {
        public Physiotherapist(PhysiotherapistData d) : base(d) { }

        public string ServiceProviderId => Data.ServiceProviderId ?? Unspecified;

    }
}
