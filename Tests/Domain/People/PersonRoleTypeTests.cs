using Abc.Aids.Random;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.People {
    [TestClass]
    public class PersonRoleTypeTests : SealedTests<DefinedEntity<PersonRoleTypeData>> {
        private PersonRoleTypeData data;
        protected override object createObject() => new PersonRoleType(data);
        [TestInitialize]
        public override void TestInitialize()
        {
            data = GetRandom.Object<PersonRoleTypeData>();
            base.TestInitialize();
        }
    }
}