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
    public class AdministratorDataTests : SealedTests<PersonData> {
        [TestMethod]
        public void AdministartorIdTest() => isProperty<string>();
    }
    [TestClass]
    public class CoachDataTests : SealedTests<PersonData> {
    }
    [TestClass]
    public class NutritionistDataTests : SealedTests<PersonData> {
    }
    [TestClass]
    public class PhysiotherapistDataTests : SealedTests<PersonData> {
    }
    [TestClass]
    public class TherapistDataTests : SealedTests<PersonData> {
    }
}
