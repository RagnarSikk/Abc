using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Facade.Others {
    [TestClass]
    public class EquipmentForPersonViewTests : SealedTests<UniqueEntityView> {

        [TestMethod] public void PersonIdTest() => isDisplayProperty<string>("Person");
        [TestMethod] public void PersonRoleTypeIdTest() => isDisplayProperty<string>("Person Role type");
        [TestMethod] public void EquipmentIdTest() => isDisplayProperty<string>("Equipment");
        [TestMethod] public void AmountTest() => isDisplayProperty<int>("Amount", false);
        [TestMethod] public void FromTest() => isDisplayProperty<DateTime?>("Valid From");
        [TestMethod] public void ToTest() => isDisplayProperty<DateTime?>("Valid To");
    }
}
