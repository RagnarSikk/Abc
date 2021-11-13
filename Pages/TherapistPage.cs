using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Infra;
using Abc.Pages.Common;
using System;


namespace Abc.Pages {
    public class TherapistPage : ViewPage<TherapistPage, ITherepistsRepository, Therapist, TherapistView, TherapistData>
    {
        public TherapistPage(ITherepistsRepository r) : base(r, "Therapists") { }
        protected internal override Uri pageUrl() => new Uri("/Therapists", UriKind.Relative);
        protected internal override Therapist toObject(TherapistView v) => new TherapistViewFacotry().Create(v);
        protected internal override TherapistView toView(Therapist o) => new TherapistViewFacotry().Create(o);


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
