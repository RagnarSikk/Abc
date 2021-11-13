using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Facade.Other
{
    public class EquipmentViewFactory : AbstractViewFactory<EquipmentData, Equipment, EquipmentView>
    {
        protected internal override Equipment toObject(EquipmentData d) => new Equipment(d);
    }
}
