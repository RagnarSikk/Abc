using Abc.Facade.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Others {

    public sealed class EquipmentView : UniqueEntityView {
        [DisplayName("Equipment ??????")] public string PersonRoleTypeId { get; set; }
        [DisplayName("Equipment Type")] public string EquipmentTypeId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Valid From")]
        public new DateTime? From { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Valid To")]
        public new DateTime? To { get; set; }
    }
}