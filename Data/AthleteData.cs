using Abc.Data.Abstract;

namespace Abc.Data {
    public class AthleteData : UniqueItemData {
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AmountOfVisits { get; set; }
        // pm saab teha ranking süsteemi nii, et iga kord kui inimene bronnerib trenni
        // saab ta +1(nt punkti), aga tuleks ka mõelda kuidas seda saab koodis realkiseerida

        //TODO: (idea) Maybe we should add somekind of a raking system? 
    }
}
