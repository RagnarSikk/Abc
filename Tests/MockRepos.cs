using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Aids.Random;
using Abc.Data.Common;
using Abc.Data.Others;
using Abc.Domain.Common;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;

namespace Abc.Tests
{
    internal static class MockRepos
    {
        public static IBodyMetricRepository BodyMetricRepository(string id, out BodyMetricData d)
            => createMockRepo<MockBodyMetricRepo, BodyMetric, BodyMetricData>( 
                id, d => new BodyMetric(d), out d);

        private class MockBodyMetricRepo : MockRepo<BodyMetric>, IBodyMetricRepository { }
        private static TRepo createMockRepo<TRepo, TObj, TData>()
            where TRepo : IRepository<TObj>, new()
            where TData : UniqueEntityData => new TRepo();

        private static TRepo createMockRepo<TRepo, TObj, TData>(string id, Func<TData, TObj> toObject, out TData data)
            where TRepo : IRepository<TObj>, new()
            where TData : UniqueEntityData
        {
            data = null;
            var count = GetRandom.UInt8(10, 20);
            var idx = GetRandom.UInt8(0, count);
            var repo = new TRepo();
            for (var i = 0; i < count; i++)
            {
                var d = GetRandom.Object<TData>();
                if (idx == i)
                {
                    d.Id = id;
                    data = d;
                }
                repo.Add(toObject(d)).GetAwaiter();
            }
            return repo;
        }

        private static TRepo createMockRepo<TRepo, TObj, TData>(
            Func<TData, TData> setRelatedId, Func<TData, TObj> toObject, out int itemsCount)
            where TRepo : IRepository<TObj>, new()
            where TData : UniqueEntityData
        {
            itemsCount = GetRandom.UInt8(3, 7);

            var repo = new TRepo();
            for (var i = 0; i < itemsCount; i++)
            {
                if (GetRandom.Bool()) repo.Add(toObject(GetRandom.Object<TData>())).GetAwaiter();
                var d = GetRandom.Object<TData>();
                d = setRelatedId(d);
                repo.Add(toObject(d)).GetAwaiter();
                if (GetRandom.Bool()) repo.Add(toObject(GetRandom.Object<TData>())).GetAwaiter();
            }
            return repo;
        }
    }
}
