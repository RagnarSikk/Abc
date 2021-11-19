using Abc.Data.Common;
using Abc.Data.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Data.People {
    [TestClass]
    public class PersonDataTests : SealedTests<UniqueEntityData> {
        [TestMethod] public void LastNameTest() => isProperty<string>();
        [TestMethod] public void FirstMidNameTest() => isProperty<string>();
        [TestMethod] public void PhoneNumberTest() => isProperty<string>();
        [TestMethod] public void EmailTest() => isProperty<string>();
        [TestMethod] public void GenderTest() => isProperty<string>();
        [TestMethod] public void DateOfBirthTest() => isProperty<DateTime?>();
    }
}
