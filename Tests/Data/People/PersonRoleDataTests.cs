using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.People {
    [TestClass]
    public class PersonRoleDataTests : SealedTests<UniqueEntityData> {
        [TestMethod] public void PersonIdTest() => isProperty<string>();
        [TestMethod] public void PersonRoleTypeIdTest() => isProperty<string>();
        [TestMethod] public void CertificateTest() => isProperty<string>();
    }
}
