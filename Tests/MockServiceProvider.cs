using System;

namespace Abc.Tests {
    internal class MockServiceProvider : IServiceProvider {
        private readonly object[] repositories;
        public MockServiceProvider(params object[] repos) => repositories = repos;
        public object GetService(Type serviceType) {
            foreach (var repository in repositories) {
                if (repository.GetType().GetInterface(serviceType.Name) is not null)
                    return repository;
            }
            return null;
        }
    }
}
