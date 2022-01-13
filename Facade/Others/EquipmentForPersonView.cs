using Abc.Facade.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Others {
    public sealed class EquipmentForPersonView : UniqueEntityView {
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Person Role type")] public string PersonRoleTypeId { get; set; }
        [DisplayName("Equipment")] public string EquipmentId { get; set; }
        [DisplayName("Amount")] public string Amount { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Valid From")]
        public new DateTime? From { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Valid To")]
        public new DateTime? To { get; set; }
    }
}
