using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others {
    [TestClass]
    public class EquipmentTypeViewTests : SealedTests<DefinedView> {
        [TestMethod] public void AmountAvailableTest() => isDisplayProperty<int>("Amount Available", false);
        [TestMethod] public void BrandIdTest() => isDisplayProperty<string>("Brand");

        [TestMethod] public void EquipmentColourIdTest() => isDisplayProperty<string>("Equipment Colour");
    }
}
