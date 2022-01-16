using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories {
    [TestClass]
    public class BodyMetricViewFactoryTests : FactoryBaseTests<BodyMetricViewFactory, BodyMetricData, BodyMetric, BodyMetricView> {
        protected override BodyMetric createObject(BodyMetricData d) => new(d);
    }
}
