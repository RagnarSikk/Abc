using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class ServiceProviderDataTests : SealedTests<UniqueEntityData> {
        [TestMethod] public void ServiceTypeIdTest() => isProperty<string>();
        [TestMethod] public void PersonIdTest() => isProperty<string>();
    }
}
