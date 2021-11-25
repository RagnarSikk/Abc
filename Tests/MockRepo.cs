using Abc.Domain.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Tests {
    internal class MockRepo<T> : IRepository<T> where T : IUniqueEntity {
        private readonly List<T> list = new();
        public string SortOrder { get; set; }
        public string SearchString { get; set; }
        public string CurrentFilter { get; set; }
        public string FixedFilter { get; set; }
        public string FixedValue { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }

        public async Task Add(T obj) => await Update(obj);
        public async Task Delete(string id) {
            var item = await Get(id);
            if (item is not null) list.Remove(item);
        }
        public Task<List<T>> Get() {
            throw new System.NotImplementedException();
        }
        public async Task<T> Get(string id) {
            await Task.CompletedTask;
            return (T)GetById(id);
        }
        public object GetById(string id) => list.Find(x => x.Id == id);
        public async Task Update(T obj) {
            if (obj is not null) {
                await Delete(obj.Id);
                list.Add(obj);
            }
        }
    }
}
