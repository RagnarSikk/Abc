using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Data.Common {
    [TestClass]
    public class PersonDataTests : AbstractTests<UniqueEntityData> {
        private class testClass : PersonData { }
        protected override PersonData createObject() => new testClass();
        [TestMethod] public void LastNameTest() => isProperty<string>();
        [TestMethod] public void FirstMidNameTest() => isProperty<string>();
        [TestMethod] public void FullNameTest() => isProperty<string>();
        [TestMethod] public void PhoneNumberTest() => isProperty<string>();
        [TestMethod] public void EmailTest() => isProperty<string>();
        [TestMethod] public void GenderTest() => isProperty<string>();
        [TestMethod] public void DateOfBirthTest() => isProperty<DateTime?>();

    }

}
