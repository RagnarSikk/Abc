using Abc.Aids.Random;
using Abc.Data.Customers;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class EquipmentTests : SealedTests<DefinedEntity<EquipmentData>> {
        private EquipmentData data;
        protected override object createObject() => new Equipment(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<EquipmentData>();
            base.TestInitialize();
        }
        [TestMethod] public void AmountAvailableTest() => isProperty(data.AmountAvailable);
        [TestMethod] public void AmountInUsingTest() => isProperty(data.AmountInUsing);
    }
    [TestClass]
    public class ServiceTests : SealedTests<UniqueEntity<ServiceData>> {
        private ServiceData data;
        protected override object createObject() => new Service(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<ServiceData>();
            base.TestInitialize();
        }
        [TestMethod] public void AthleteIdTest() => isProperty(data.AthleteId);
        [TestMethod] public void ServiceProviderIdTest() => isProperty(data.ServiceProviderId);
    }
    [TestClass]
    public class ServiceProviderTests : SealedTests<UniqueEntity<ServiceProviderData>> {
        private ServiceProviderData data;
        protected override object createObject() => new ServiceProvider(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<ServiceProviderData>();
            base.TestInitialize();
        }
        [TestMethod] public void ServiceTypeIdTest() => isProperty(data.ServiceTypeId);
        [TestMethod] public void PersonIdTest() => isProperty(data.PersonId);
    }
    [TestClass]
    public class ServiceTypeTests : SealedTests<DefinedEntity<ServiceTypeData>> {
        
    }
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
