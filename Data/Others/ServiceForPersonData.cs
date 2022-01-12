
using Abc.Data.Common;

namespace Abc.Data.Others {
    public sealed class ServiceForPersonData : UniqueEntityData {
        public string PersonId { get; set; }
        public string ServiceId { get; set; }
    }
}
