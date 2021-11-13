using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Infra;
using Abc.Pages.Common;
using System;


namespace Abc.Pages {
    public class CoachPage : ViewPage<CoachPage, ICoachesRepository, Coach, CoachView, CoachData>
    {
        public CoachPage(ICoachesRepository r) : base(r, "Coaches") { }
        protected internal override Uri pageUrl() => new Uri("/Coaches", UriKind.Relative);
        protected internal override Coach toObject(CoachView v) => new CoachViewFacotry().Create(v);
        protected internal override CoachView toView(Coach o) => new CoachViewFacotry().Create(o);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.LastName);
            createColumn(x => Item.FirstMidName);
            createColumn(x => Item.DateOfBirth);
            createColumn(x => Item.Gender);
            createColumn(x => Item.PhoneNumber);
            createColumn(x => Item.Email);
        }
    }
}
