using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Infra.Common;

namespace Abc.Infra.Others {
    public sealed class EquipmentForPersonRepository : UniqueEntitiesRepository<EquipmentForPerson, EquipmentForPersonData>, IEquipmentForPersonRepository {
        public EquipmentForPersonRepository(TrainingDbContext c) : base(c, c.EquipmentsForPerson) { }

        protected internal override EquipmentForPerson toDomainObject(EquipmentForPersonData d) => new EquipmentForPerson(d);
    }
}
