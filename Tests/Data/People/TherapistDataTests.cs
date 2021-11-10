using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.People {
    [TestClass]
    public class TherapistDataTests : SealedTests<PersonData> {
        [TestMethod] public void ServiceProviderIdTest() => isProperty<string>();
    }
}
