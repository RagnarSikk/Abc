﻿using Abc.Data.Common;
using Abc.Data.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.People {
    [TestClass]
    public class TherapistDataTests : SealedTests<PersonData> {
        [TestMethod] public void ServiceProviderIdTest() => isProperty<string>();
    }
}
