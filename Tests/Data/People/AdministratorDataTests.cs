using Abc.Data.Common;
using Abc.Data.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Tests.Data.People {
    [TestClass]
    public class AdminstratorDataTests : SealedTests<AdminstratorData, PersonData> {
        [TestMethod]
        public void AdministartorIdTest() {
            Assert.Inconclusive();
        }
    }
    [TestClass]
    public class CoachDataTests : SealedTests<CoachData, PersonData> {
    }
    [TestClass]
    public class NutritionistDataTests : SealedTests<NutritionistData, PersonData> {
    }
    [TestClass]
    public class PhysiotherapistDataTests : SealedTests<PhysiotherapistData, PersonData> {
    }
    [TestClass]
    public class TherapistDataTests : SealedTests<TherapistData, PersonData> {
    }
}
