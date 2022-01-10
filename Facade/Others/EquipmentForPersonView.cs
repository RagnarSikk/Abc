using System;
using Abc.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Others {
    public sealed class EquipmentForPersonView : NamedView {
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Equipment")] public string EquipmentId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Valid From")]
        public new DateTime? From { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Valid To")]
        public new DateTime? To { get; set; }
    }
}
