using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class EquipmentTests : SealedTests<UniqueEntity<EquipmentData>> {
        private EquipmentData data;
        private IPersonRoleTypeRepository personRoleTypeRepo;
        private IEquipmentTypeRepository equipmentTypeRepo;
        private PersonRoleTypeData personRoleTypeData;
        private EquipmentTypeData equipmentTypeData;
        private Equipment equipment;

        protected override object createObject() => new Equipment(data);

        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<EquipmentData>();
            personRoleTypeRepo = MockRepos.PersonRoleTypeRepository(data.PersonRoleTypeId, out personRoleTypeData);
            equipmentTypeRepo = MockRepos.EquipmentTypeRepository(data.EquipmentTypeId, out equipmentTypeData);
            base.TestInitialize();
            equipment = obj as Equipment;
        }

        [TestMethod] public void PersonRoleTypeIdTest() => isProperty(data.PersonRoleTypeId);
        [TestMethod] public void EquipmentTypeIdTest() => isProperty(data.EquipmentTypeId);

        [TestMethod]
        public void PersonRoleTypeTest() {
            isNull(equipment.PersonRoleType);
            GetRepository.SetServiceProvider(new MockServiceProvider(personRoleTypeRepo));
            areEqualProperties(personRoleTypeData, equipment.PersonRoleType.Data);
        }
        [TestMethod]
        public void EquipmentTypeTest() {
            isNull(equipment.EquipmentType);
            GetRepository.SetServiceProvider(new MockServiceProvider(equipmentTypeRepo));
            areEqualProperties(equipmentTypeData, equipment.EquipmentType.Data);
        }
    }
}
