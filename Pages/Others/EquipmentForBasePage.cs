using Abc.Domain.Others.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Pages.Others {
    public sealed class EquipmentForBasePage : EquipmentForPersonPage<EquipmentForBasePage> {
        public EquipmentForBasePage(IEquipmentForPersonRepository r) : base(r) { }
    }
}
