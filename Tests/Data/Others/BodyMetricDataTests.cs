using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others
{
    [TestClass]
    public class BodyMetricDataTests : SealedTests<UniqueEntityData>
    {
        [TestMethod] public void WeightTest() => isProperty<double>(false);
        [TestMethod] public void HeightTest() => isProperty<double>(false);
        [TestMethod] public void PersonIdTest() => isProperty<string>();
        [TestMethod] public void BodyMetricTypeIdTest() => isProperty<string>();
    }
}
