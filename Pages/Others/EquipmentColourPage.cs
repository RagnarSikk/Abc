using Abc.Domain.Others.Repositories;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Abc.Pages.Others {
    [Authorize]
    public class EquipmentColourPage : EquipmentColourBasePage<EquipmentColourPage> {
        public EquipmentColourPage(IEquipmentColourRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new Uri("/AdminView/EquipmentColours", UriKind.Relative);
    }

}
