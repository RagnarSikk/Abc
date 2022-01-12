using System;
using Abc.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Others {
    public sealed class ServiceForPersonView : UniqueEntityView {
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Service")] public string ServiceId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Valid From")]
        public new DateTime? From { get; set; }
        
        [DataType(DataType.DateTime)]
        [DisplayName("Valid To")]
        public new DateTime? To { get; set; }
    }
}
