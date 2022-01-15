using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories {
    [TestClass]
    public class BodyMetricTypeViewFactoryTests : FactoryBaseTests<BodyMetricTypeViewFactory, BodyMetricTypeData, BodyMetricType, BodyMetricTypeView>
    {
        protected override BodyMetricType createObject(BodyMetricTypeData d) => new(d);
    }
}
