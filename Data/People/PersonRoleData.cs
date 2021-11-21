using Abc.Data.Common;

namespace Abc.Data.People {
    public sealed class PersonRoleData : UniqueEntityData {
        public string PersonId { get; set; }
        public string PersonRoleTypeId { get; set; }
        public string Certificate { get; set; }
    }
}
