using System;
using System.ComponentModel;
using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.People {
    [TestClass]
    public class PersonViewTests : SealedTests<UniqueEntityView>
    {
        [TestMethod] public void LastNameTest() => isDisplayProperty<string>("Last Name");
        [TestMethod] public void FirstMidNameTest() => isDisplayProperty<string>("First Middle Name");
        [TestMethod] public void PhoneNumberTest() => isDisplayProperty<string>("Phone Number");
        [TestMethod] public void EmailTest() => isDisplayProperty<string>("Email");
        [TestMethod] public void GenderTest() => isDisplayProperty<string>("Gender");
        [TestMethod] public void DateOfBirthTest() => isDisplayProperty<DateTime?>("Date of Birth");
    }
}
