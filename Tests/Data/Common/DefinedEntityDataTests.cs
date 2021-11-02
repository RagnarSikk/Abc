using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Abc.Tests.Data.Common {
    [TestClass]
    public class DefinedEntityDataTests : AbstractTests<DefinedEntityData, NamedEntityData> {
        protected override DefinedEntityData createObject() {
            throw new System.NotImplementedException();
        }
    }
    [TestClass]
    public class NamedEntityDataTests : AbstractTests<NamedEntityData, UniqueEntityData> {
        protected override NamedEntityData createObject() {
            throw new System.NotImplementedException();
        }
    }
    [TestClass]
    public class PeriodDataTests : AbstractTests<PeriodData, object> {
        protected override PeriodData createObject() {
            throw new System.NotImplementedException();
        }
    }
    [TestClass]
    public class PersonDataTests : AbstractTests<PersonData, UniqueEntityData> {
        protected override PersonData createObject() {
            throw new System.NotImplementedException();
        }
    }
    [TestClass]
    public class UniqueEntityDataTests : AbstractTests<UniqueEntityData, PeriodData> {
        protected override UniqueEntityData createObject() {
            throw new System.NotImplementedException();
        }
    }

}
