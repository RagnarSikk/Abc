using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Abc.Tests.Data.Common {
    [TestClass]
    public class DefinedEntityDataTests : AbstractTests<NamedEntityData> {
        protected override DefinedEntityData createObject() {
            throw new System.NotImplementedException();
        }
    }
    [TestClass]
    public class NamedEntityDataTests : AbstractTests<UniqueEntityData> {
        protected override NamedEntityData createObject() {
            throw new System.NotImplementedException();
        }
    }
    [TestClass]
    public class PeriodDataTests : AbstractTests<object> {
        protected override PeriodData createObject() {
            throw new System.NotImplementedException();
        }
    }
    [TestClass]
    public class PersonDataTests : AbstractTests<UniqueEntityData> {
        protected override PersonData createObject() {
            throw new System.NotImplementedException();
        }
    }
    [TestClass]
    public class UniqueEntityDataTests : AbstractTests<PeriodData> {
        protected override UniqueEntityData createObject() {
            throw new System.NotImplementedException();
        }
    }

}
