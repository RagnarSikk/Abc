using Abc.Data.Common;
using Abc.Data.Others;

namespace Abc.Domain.Common {

    public abstract class DefinedEntity<T> : NamedEntity<T>, IDefinedEntity<T> where T : DefinedEntityData, new() {
        private EquipmentColourData d;

        protected DefinedEntity(EquipmentColourData d)
        {
            this.d = d;
        }

        protected internal DefinedEntity(T d = null) : base(d) { }

        public virtual string Definition => Data?.Definition ?? Unspecified;

    }

}

