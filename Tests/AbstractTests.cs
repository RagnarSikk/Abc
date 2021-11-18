using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests {
    public abstract class AbstractTests<TBaseClass> : BaseClassTests<TBaseClass> {
        [TestMethod] public void IsAbstract() => Assert.IsTrue(type.IsAbstract);

    }
}

