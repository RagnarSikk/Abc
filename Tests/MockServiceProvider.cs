using System;

namespace Abc.Tests {
    internal class MockServiceProvider : IServiceProvider {
        private readonly object reporitory;
        public MockServiceProvider(object repo) => reporitory = repo;
        public object GetService(Type serviceType) => reporitory;
    }
}
