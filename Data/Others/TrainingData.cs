using Abc.Data.Common;

namespace Abc.Data.Others {
    public class TrainingData : DefinedEntityData {
        public string LocationOfTraining { get; set; }
        public string AvailableEquipment { get; set; }
        public int MaxNumberOfAthletes { get; set; }  
        public int MinNumberOfAthletes { get; set; }
        public int NumberOfAthletes { get; set; }
        public int NumberOfCoachesRequired { get; set; }

    }
}
