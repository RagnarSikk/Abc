using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Tests {
    internal class MockRepo<T> : IRepository<T> where T : IUniqueEntity<T> {
        private readonly List<T> list = new List<T>();
        public string SortOrder { get; set; }
        public string SearchString { get; set; }
        public string CurrentFilter { get; set; }
        public string FixedFilter { get; set; }
        public string FixedValue { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public int TotalPages => throw new NotImplementedException();

        public bool HasNextPage => throw new NotImplementedException();

        public bool HasPreviousPage => throw new NotImplementedException();

        public async Task Add(T obj) => await Update(obj);

        public async Task Delete(string id) {
            var item = await Get(id);
            if (item is not null) list.Remove(item);
        }
        public Task<List<T>> Get() {
            throw new NotImplementedException();
        }
        public async Task<T> Get(string id) {
            await Task.CompletedTask;
            return (T)GetById(id);
        }

        public object GetById(string id) => list.Find(x => x.Id == id);

        public Task Update(T obj) {
            if (obj is not null) {
                Delete(obj.Id);
                list.Add(obj);
            }
            return Task.CompletedTask;
        }
    }
}
