using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class TrainingTests : SealedTests<DefinedEntity<TrainingData>> {
        private TrainingData data;
        protected override object createObject() => new Training(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<TrainingData>();
            base.TestInitialize();
        }
        [TestMethod] public void LocationOfTrainingTest() => isProperty(data.LocationOfTraining);
        [TestMethod] public void AvailableEquipmentTest() => isProperty(data.AvailableEquipment);
        [TestMethod] public void MaxNumberOfAthletesTest() => isProperty(data.MaxNumberOfAthletes);
        [TestMethod] public void MinNumberOfAthletesTest() => isProperty(data.MinNumberOfAthletes);
        [TestMethod] public void NumberOfAthletesTest() => isProperty(data.NumberOfAthletes);
        [TestMethod] public void NumberOfCoachesRequiredTest() => isProperty(data.NumberOfCoachesRequired);
    }
}
