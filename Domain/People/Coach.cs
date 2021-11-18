using Abc.Data.People;
using Abc.Domain.Common;

namespace Abc.Domain.People {
    public sealed class Coach : Person<CoachData> {
        public Coach(CoachData d) : base(d) { }

    }

}
