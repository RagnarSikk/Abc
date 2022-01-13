using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Infra.Common;

namespace Abc.Infra.Others {
    public sealed class BrandRepository : UniqueEntitiesRepository<Brand, BrandData>, IBrandRepository {
        public BrandRepository(TrainingDbContext c) : base(c, c.Brand) { }

        protected internal override Brand toDomainObject(BrandData d) => new Brand(d);
    }
}