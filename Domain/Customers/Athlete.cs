using Abc.Data.Customers;
using Abc.Domain.Common;

namespace Abc.Domain.Customers {
    public sealed class Athlete : Person<AthleteData> {
        public Athlete(AthleteData d) : base(d) { }
        public double Weight => Data?.Weight ?? UnspecifiedDouble;
        public double Height => Data?.Height ?? UnspecifiedDouble;
        public int AmountOfVisits => Data?.AmountOfVisits ?? UnspecifiedInteger;

    }
}

