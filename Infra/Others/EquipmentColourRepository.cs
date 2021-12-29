using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Infra.Common;

namespace Abc.Infra.Others {
    public sealed class EquipmentColourRepository : UniqueEntitiesRepository<EquipmentColour, EquipmentColourData>, IEquipmentColourRepository {
        public EquipmentColourRepository(TrainingDbContext c) : base(c, c.EquipmentColours) { }

        protected internal override EquipmentColour toDomainObject(EquipmentColourData d) => new EquipmentColour(d);
    }
}