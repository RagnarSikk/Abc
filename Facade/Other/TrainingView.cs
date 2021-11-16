using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Other
{
    public sealed class TrainingView: DefinedView
    {
        [DisplayName("Location of Training")]
        public string LocationOfTraining { get; set; }
        [DisplayName("Available Equipment")]
        public string AvailableEquipment { get; set; }
        [DisplayName("Max Number Of Athletes")]
        public int MaxNumberOfAthletes { get; set; }
        [DisplayName("Min Number Of Athletes")]
        public int MinNumberOfAthletes { get; set; }
        [DisplayName("Number Of Athletes")]
        public int NumberOfAthletes { get; set; }
        [DisplayName("Number Of Coaches Required")]
        public int NumberOfCoachesRequired { get; set; }
    }
}