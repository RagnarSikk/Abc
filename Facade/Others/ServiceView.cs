using Abc.Facade.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Others {
    public sealed class ServiceView : UniqueEntityView {
        [DisplayName("Service Provider")] public string PersonRoleTypeId { get; set; }
        [DisplayName("Service Type")] public string ServiceTypeId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Valid From")]
        public new DateTime? From { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Valid To")]
        public new DateTime? To { get; set; }
    }
}
