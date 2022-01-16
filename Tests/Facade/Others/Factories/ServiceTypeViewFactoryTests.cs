using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories {

    [TestClass]
    public class ServiceTypeViewFactoryTests : FactoryBaseTests<ServiceTypeViewFactory, ServiceTypeData, ServiceType, ServiceTypeView> {
        protected override ServiceType createObject(ServiceTypeData d) => new(d);
    }
}