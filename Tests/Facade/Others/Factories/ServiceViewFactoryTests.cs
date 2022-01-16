using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories {
    [TestClass]
    public class ServiceViewFactoryTests : FactoryBaseTests<ServiceViewFactory, ServiceData, Service, ServiceView> {
        protected override Service createObject(ServiceData d) => new(d);
    }
}