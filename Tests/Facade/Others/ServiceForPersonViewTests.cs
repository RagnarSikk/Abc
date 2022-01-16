using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Facade.Others {
    [TestClass]
    public class ServiceForPersonViewTests : SealedTests<UniqueEntityView> {

        [TestMethod] public void PersonIdTest() => isDisplayProperty<string>("Person");
        [TestMethod] public void ServiceIdTest() => isDisplayProperty<string>("Service");
        [TestMethod] public void FromTest() => isDisplayProperty<DateTime?>("Valid From");
        [TestMethod] public void ToTest() => isDisplayProperty<DateTime?>("Valid To");
    }
}
