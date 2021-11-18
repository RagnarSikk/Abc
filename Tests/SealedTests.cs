using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests {
    public abstract class SealedTests<TBaseClass> : ClassTests<TBaseClass> {
        [TestMethod] public void IsSealed() => isTrue(type.IsSealed);
    }

}

