using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Others.Factories {
    [TestClass]
    public class ServiceForPersonViewFactoryTests : FactoryBaseTests<ServiceForPersonViewFactory, ServiceForPersonData, ServiceForPerson, ServiceForPersonView>
    {
        protected override ServiceForPerson createObject(ServiceForPersonData d) => new(d);
    }
}
