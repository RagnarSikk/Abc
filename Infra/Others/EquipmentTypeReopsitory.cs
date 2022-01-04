using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Infra.Common;

namespace Abc.Infra.Others {
    public sealed class EquipmentTypeRepository : UniqueEntitiesRepository<EquipmentType, EquipmentTypeData>, IEquipmentTypeRepository {
        public EquipmentTypeRepository(TrainingDbContext c) : base(c, c.EquipmentTypes) { }

        protected internal override EquipmentType toDomainObject(EquipmentTypeData d) => new(d);
    }
}
