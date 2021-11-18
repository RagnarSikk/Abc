using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Common;

namespace Abc.Infra.Others {
    public sealed class EquipmentRepository : UniqueEntitiesRepository<Equipment, EquipmentData>, IEquipmentRepository {
        public EquipmentRepository(TrainingDbContext c) : base(c, c.Equipments) { }
        protected internal override Equipment toDomainObject(EquipmentData d) => new Equipment(d);

    }
}
