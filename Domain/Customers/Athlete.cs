using Abc.Data.Customers;
using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Domain.Customers
{
    public sealed class Athlete : UniqueEntity<AthleteData>
    {
        public Athlete(AthleteData d) : base(d) { }
        public double Weight => Data?.Weight ?? UnspecifiedDouble;
        public double Height => Data?.Height ?? UnspecifiedDouble;
        public int AmountOfVisits => Data?.AmountOfVisits ?? UnspecifiedInteger;

    }
}
 
