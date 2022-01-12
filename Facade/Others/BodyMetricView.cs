﻿using System;
using Abc.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Others {
    public sealed class BodyMetricView : UniqueEntityView {
        [DisplayName("Value")] public double Value { get; set; }
        [DisplayName("Person")] public string PersonId { get; set; }
        [DisplayName("Type")] public string BodyMetricTypeId { get; set; }
    }
}
