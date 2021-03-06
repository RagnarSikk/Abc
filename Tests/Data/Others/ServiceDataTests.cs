using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class ServiceDataTests : SealedTests<UniqueEntityData> {
        [TestMethod] public void PersonRoleTypeIdTest() => isProperty<string>();
        [TestMethod] public void ServiceTypeIdTest() => isProperty<string>();
    }
}
