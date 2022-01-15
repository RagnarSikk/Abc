using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others {
   [TestClass]
    public  class ServiceViewTests : SealedTests<UniqueEntityView>
    {
        [TestMethod] public void PersonRoleTypeIdTest() => isDisplayProperty<string>("Service Provider");
        [TestMethod] public void ServiceTypeIdTest() => isDisplayProperty<string>("Service Type");
        [TestMethod] public void FromTest() => isDisplayProperty<DateTime?>("Valid From");
        [TestMethod] public void ToTest() => isDisplayProperty<DateTime?>("Valid To");
    }
}
