using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Infra.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Infra.Others { 
    public class EquipmentTypeRepository : UniqueEntitiesRepository<EquipmentType, EquipmentTypeData>, IEquipmentTypeRepository {
        public EquipmentTypeRepository(TrainingDbContext c) : base(c, c.EquipmentTypes) { }

        protected internal override EquipmentType toDomainObject(EquipmentTypeData d) => new(d);
    }
}
