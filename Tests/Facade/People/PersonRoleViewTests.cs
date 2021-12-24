using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.People {
    [TestClass]
    public class PersonRoleViewTests : SealedTests<UniqueEntityView> {
        //[TestMethod] public string PersonId { get; set; } 
        //[TestMethod] public string PersonRoleTypeId { get; set; }
        [TestMethod] public void CertificateTest() => isDisplayProperty<string>("Certificate");
    }
}
