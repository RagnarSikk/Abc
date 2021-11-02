using Abc.Data.People;
using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Domain.People
{
    public sealed class Administrator : UniqueEntity<AdministratorData>
    {
        public Administrator(AdministratorData d) : base(d) { }
        public string AdministartorId => Data?.AdministartorId ?? Unspecified;

    }
    public sealed class Coach : UniqueEntity<CoachData>
    {
        public Coach(CoachData d) : base(d) { }
        

    }
    public sealed class Nutritionist : UniqueEntity<NutritionistData>
    {
        public Nutritionist(NutritionistData d) : base(d) { }


    }
    public sealed class Physiotherapist : UniqueEntity<PhysiotherapistData>
    {
        public Physiotherapist(PhysiotherapistData d) : base(d) { }


    }
    public sealed class Therapist : UniqueEntity<TherapistData>
    {
        public Therapist(TherapistData d) : base(d) { }


    }
}
