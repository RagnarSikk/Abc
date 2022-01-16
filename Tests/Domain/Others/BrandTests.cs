using Abc.Aids.Random;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Others {
    [TestClass]
    public class BrandTests : SealedTests<DefinedEntity<BrandData>> {
        private BrandData data;
        protected override object createObject() => new Brand(data);
        [TestInitialize]
        public override void TestInitialize() {
            data = GetRandom.Object<BrandData>();
            base.TestInitialize();
        }

    }
}
