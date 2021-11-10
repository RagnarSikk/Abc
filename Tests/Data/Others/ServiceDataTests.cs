using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class ServiceDataTests : SealedTests<UniqueEntityData> {
        [TestMethod] public void ServiceProviderIdTest() => isProperty<string>();
        [TestMethod] public void AthleteIdTest() => isProperty<string>();
    }
}
