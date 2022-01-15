using Abc.Facade.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others {
    [TestClass]

    public class EquipmentViewTests : SealedTests<UniqueEntityView> {
        [TestMethod] public void EquipmentTypeIdTest() => isDisplayProperty<string>("Equipment Type");
        [TestMethod] public void PersonRoleTypeIdTest() => isDisplayProperty<string>("Equipment ??????");
        [TestMethod] public void AmountTest() => isDisplayProperty<int>("Amount", false);
        [TestMethod] public void FromTest() => isDisplayProperty<DateTime?>("Valid From");
        [TestMethod] public void ToTest() => isDisplayProperty<DateTime?>("Valid To");
    }
}