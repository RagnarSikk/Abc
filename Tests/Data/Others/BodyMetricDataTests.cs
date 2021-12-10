using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class BodyMetricDataTests : SealedTests<UniqueEntityData> {
        [TestMethod] public void ValueTest() => isProperty<double>(false);
        [TestMethod] public void PersonIdTest() => isProperty<string>();
        [TestMethod] public void BodyMetricTypeIdTest() => isProperty<string>();
    }
}
