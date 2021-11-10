using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Others {
    [TestClass]
    public class TrainingDataTests : SealedTests<DefinedEntityData> {
        [TestMethod]
        public void LocationOfTrainingTest() => isProperty<string>();
        [TestMethod]
        public void AvailableEquipmentTest() => isProperty<string>();
        [TestMethod]
        public void MaxNumberOfAthletesTest() => isProperty<int>(false);
        [TestMethod]
        public void MinNumberOfAthletesTest() => isProperty<int>(false);
        [TestMethod]
        public void NumberOfAthletesTest() => isProperty<int>(false);
        [TestMethod]
        public void NumberOfCoachesRequiredTest() => isProperty<int>(false);
    }
}
