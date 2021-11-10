using Abc.Aids.Random;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Tests.Domain.People {
    [TestClass]
    public class AdministratorTests : SealedTests<Person<AdministratorData>> {
    }
    [TestClass]
    public class CoachTests : SealedTests<Person<CoachData>> {
    }
    [TestClass]
    public class NutritionistTests : SealedTests<Person<NutritionistData>> {
        private NutritionistData data;
        protected override object createObject() => new Nutritionist(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<NutritionistData>();
            base.TestInitialize();
        }
        [TestMethod] public void ServiceProviderIdTest() => isProperty(data.ServiceProviderId);
    }
    [TestClass]
    public class PhysiotherapistTests : SealedTests<Person<PhysiotherapistData>> {
        private PhysiotherapistData data;
        protected override object createObject() => new Physiotherapist(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<PhysiotherapistData>();
            base.TestInitialize();
        }
        [TestMethod] public void ServiceProviderIdTest() => isProperty(data.ServiceProviderId);
    }
    [TestClass]
    public class TherapistTests : SealedTests<Person<TherapistData>> {
        private TherapistData data;
        protected override object createObject() => new Therapist(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<TherapistData>();
            base.TestInitialize();
        }
        [TestMethod] public void ServiceProviderIdTest() => isProperty(data.ServiceProviderId);
    }
}
