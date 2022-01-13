using Abc.Domain.Others.Repositories;
using System;

namespace Abc.Pages.Others {
    public class EquipmentColourPage : EquipmentColourBasePage<EquipmentColourPage> {
        public EquipmentColourPage(IEquipmentColourRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new Uri("/AdminView/EquipmentColours", UriKind.Relative);
    }

}
