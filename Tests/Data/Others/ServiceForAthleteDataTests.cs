﻿using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class ServiceForAthleteDataTests : SealedTests<UniqueEntityData> {
        [TestMethod]
        public void PersonIdTest() => isProperty<string>();
        [TestMethod]
        public void ServiceIdTest() => isProperty<string>();

    }
}
