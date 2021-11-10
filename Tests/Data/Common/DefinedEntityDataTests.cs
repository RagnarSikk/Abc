using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Data.Common {
    [TestClass]
    public class DefinedEntityDataTests : AbstractTests<NamedEntityData> {
        private class testClass : DefinedEntityData { }
        protected override DefinedEntityData createObject() => new testClass();
        [TestMethod] public void DefinitionTest() => isProperty<string>();
    }
    [TestClass]
    public class NamedEntityDataTests : AbstractTests<UniqueEntityData> {
        private class testClass : NamedEntityData { }
        protected override NamedEntityData createObject() => new testClass();
        [TestMethod] public void NameTest() => isProperty<string>();
    }
    [TestClass]
    public class PeriodDataTests : AbstractTests<object> {
        private class testClass : PeriodData { }
        protected override PeriodData createObject() => new testClass();
        [TestMethod] public void FromTest() => isProperty<DateTime?>();
        [TestMethod] public void ToTest() => isProperty<DateTime?>();
    }
    
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
    [TestClass]
    public class UniqueEntityDataTests : AbstractTests<PeriodData> {
        private class testClass : UniqueEntityData { }
        protected override UniqueEntityData createObject() => new testClass();
        [TestMethod] public void IdTest() => isProperty<string>();
    }

}
