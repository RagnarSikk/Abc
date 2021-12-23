using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Facade.Others.Factories {
    public class EquipmentForPersonViewFactory : AbstractViewFactory<EquipmentForPersonData, EquipmentForPerson, EquipmentForPersonView> {
        protected internal override EquipmentForPerson toObject(EquipmentForPersonData d) => new(d);
    }
}
