using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    class EquipmentForPersonTest : SealedTests<UniqueEntity<EquipmentForPersonData>> {
        private EquipmentForPersonData data;
        private IPersonRepository personRepo;
        private IEquipmentRepository equipmentRepo;
        private PersonData personData;
        private EquipmentData equipmentData;
        private EquipmentForPerson equipmentForPerson;

        protected override object createObject() => new EquipmentForPerson(data);
    }
}
