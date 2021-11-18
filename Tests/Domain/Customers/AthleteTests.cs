//using Abc.Aids.Random;
//using Abc.Data.Customers;
//using Abc.Domain.Common;
//using Abc.Domain.Customers;
//using Abc.Domain.People;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Abc.Tests.Domain.Customers {
//    [TestClass]
//    public class AthleteTests : SealedTests<Person<AthleteData>> {
//        private AthleteData data;
//        protected override object createObject() => new Athlete(data);

//        [TestInitialize]
//        public override void TestInitialize() {
//            data = GetRandom.Object<AthleteData>();
//            base.TestInitialize();
//        }
//        [TestMethod] public void WeightTest() => isProperty(data.Weight);
//        [TestMethod] public void HeightTest() => isProperty(data.Height);
//        [TestMethod] public void AmountOfVisitsTest() => isProperty(data.AmountOfVisits);
//    }
//}
