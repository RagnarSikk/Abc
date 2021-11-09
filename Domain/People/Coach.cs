using Abc.Data.People;
using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Domain.People
{
    public sealed class Coach : Person<CoachData>
    {
        public Coach(CoachData d) : base(d) { }

    }
   
}
