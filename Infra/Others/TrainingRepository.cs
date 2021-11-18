using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Infra.Common;

namespace Abc.Infra.Others {
    public sealed class TrainingRepository : UniqueEntitiesRepository<Training, TrainingData>, ITrainingRepository {
        public TrainingRepository(TrainingDbContext c) : base(c, c.Trainings) { }
        protected internal override Training toDomainObject(TrainingData d) => new Training(d);

    }
}
