using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Common;

namespace Abc.Facade.People
{
    public class CoachViewFacotry : AbstractViewFactory<CoachData, Coach, CoachView>
    {
        protected internal override Coach toObject(CoachData d) => new Coach(d);
    }
}
