using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.People {
    [TestClass]
    public class PersonRoleViewTests : SealedTests<UniqueEntityView> {
        [TestMethod] public void  PersonIdTest() => isDisplayProperty<string>("Person");
        [TestMethod] public void PersonRoleTypeIdTest() => isDisplayProperty<string>("Role Type");
        [TestMethod] public void CertificateTest() => isDisplayProperty<string>("Certificate");
        
    }
}
