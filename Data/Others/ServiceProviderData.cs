using Abc.Data.Common;

namespace Abc.Data.Others
{
    //ServiceProvider võimaldab inimestel pakkuda teenuseid
    public class ServiceProviderData : UniqueEntityData
    {
        public string ServiceTypeId { get; set; }
        public string PersonId { get; set; }
    }
}