using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others {
    [TestClass]
    public class BodyMetricViewTests : SealedTests<UniqueEntityView> {
        [TestMethod] public void ValueTest() => isDisplayProperty<double>("Value", false);
        [TestMethod] public void PersonIdTest() => isDisplayProperty<string>("Person");
        [TestMethod] public void BodyMetricTypeIdTest() => isDisplayProperty<string>("Type");
    }
}
