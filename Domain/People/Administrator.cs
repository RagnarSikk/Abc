using Abc.Data.People;
using Abc.Domain.Common;

namespace Abc.Domain.People {
    public sealed class Administrator : Person<AdministratorData> {
        public Administrator(AdministratorData d) : base(d) { }

    }
}
