using Abc.Data.Common;
using Abc.Facade.Common;
using System.ComponentModel;

namespace Abc.Facade.Customers
{
    public sealed class AthleteView : UniqueEntityView
    {
        [DisplayName("Weight")]
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AmountOfVisits { get; set; }
        //TODO: (idea) Maybe we should add somekind of a raking system? 
    }
}
