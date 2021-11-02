using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests {
    public class TestAssertions {
        protected static void notTested(string message = null) => Assert.Inconclusive(message);
        protected static void notTested(string message, params object[] parameters)
            => Assert.Inconclusive(message, parameters);
        protected static void areEqual<TExpected, TActual>(TExpected e, TActual a) => Assert.AreEqual(e, a);
    }
}
