using Abc.Data.Others;
using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Domain.Others
{
    public sealed class Training : DefinedEntity<TrainingData>
    {
        public Training(TrainingData d) : base(d) { }

        public string LocationOfTraining => Data?.LocationOfTraining ?? Unspecified;

        public string AvailableEquipment => Data?.AvailableEquipment ?? Unspecified;
        public int MaxNumberOfAthletes => Data?.MaxNumberOfAthletes ?? UnspecifiedInteger;
        public int MinNumberOfAthletes => Data?.MinNumberOfAthletes ?? UnspecifiedInteger;
        public int NumberOfAthletes => Data?.NumberOfAthletes ?? UnspecifiedInteger;
        public int NumberOfCoachesRequired => Data?.NumberOfCoachesRequired ?? UnspecifiedInteger;

    }
}
