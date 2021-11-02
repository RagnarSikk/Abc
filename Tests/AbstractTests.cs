using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests
{
    public abstract class AbstractTests<TClass, TBaseClass> :
        BaseClassTests<TClass, TBaseClass> where TClass : class
    {
        [TestMethod] public void IsAbstract() => Assert.IsTrue(type.IsAbstract);

    }
}

