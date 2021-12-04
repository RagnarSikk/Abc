using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others {
    public class TrainingViewFactory : AbstractViewFactory<TrainingData, Training, TrainingView> {
        protected internal override Training toObject(TrainingData d) => new Training(d);
    }
}
