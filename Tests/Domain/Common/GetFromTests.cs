using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common
{
    [TestClass]
    public class GetFromTests : SealedTests<object>
    {
        protected override object createObject() => new GetFrom<IEquipmentRepository, Equipment>();

        private string id;
        private IEquipmentRepository equipmentRepo;
        private MockServiceProvider provider;
        private EquipmentData equipmentData;

        [TestInitialize]
        public override void TestInitialize()
        {
            type = typeof(GetRepository);
            id = GetRandom.String();
            equipmentRepo = MockRepos.EquipmentRepository(id, out equipmentData);
            provider = new MockServiceProvider(equipmentRepo);
            GetRepository.SetServiceProvider(provider);
            base.TestInitialize();
        }
        [TestMethod]
        public void ByIdTest()
        {
            var o = new GetFrom<IEquipmentRepository, Equipment>().ById(id);
            areEqualProperties(equipmentData, o.Data);
        }
        //[TestMethod]
        //public void ListByTest()
        //{
        //    var l = new GetFrom<IEquipmentRepository, Equipment>().ListBy(nameof(equipmentData.PersonRoleTypeId), equipmentData.PersonRoleTypeId);
        //    areEqual(1, l.Count);
        //    areEqualProperties(equipmentData, l[0].Data);
        //}
        //[TestMethod]
        //public void ListBySearchStringTest()
        //{
        //    var l = new GetFrom<IEquipmentRepository, Equipment>().ListBy(null, null, null);
        //    areEqual(equipmentRepo.Get().GetAwaiter().GetResult().Count, l.Count);
        //}
    }
}