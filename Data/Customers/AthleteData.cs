using Abc.Data.Common;

namespace Abc.Data.Customers {
    public class AthleteData : PersonData {
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AmountOfVisits { get; set; }
        //TODO: (idea) Maybe we should add somekind of a raking system? 
    }
}
