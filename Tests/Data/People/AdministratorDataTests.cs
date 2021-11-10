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
    }
    [TestClass]
    public class CoachDataTests : SealedTests<PersonData> {
    }
    [TestClass]
    public class NutritionistDataTests : SealedTests<PersonData> {
        [TestMethod] public void ServiceProviderIdTest() => isProperty<string>();
    }
    [TestClass]
    public class PhysiotherapistDataTests : SealedTests<PersonData> {
        [TestMethod] public void ServiceProviderIdTest() => isProperty<string>();
    }
    [TestClass]
    public class TherapistDataTests : SealedTests<PersonData> {
        [TestMethod] public void ServiceProviderIdTest() => isProperty<string>();
    }
}
