﻿using Abc.Data.Common;

namespace Abc.Data.Others {
    public sealed class ServiceData : UniqueEntityData {
        public string ServiceProviderRoleId { get; set; }
        public string ServiceTypeId { get; set; }
    }
}
