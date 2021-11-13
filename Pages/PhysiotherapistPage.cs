using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Infra;
using Abc.Pages.Common;
using System;

namespace Abc.Pages {
    public class PhysiotherapistPage : ViewPage<PhysiotherapistPage, IPhysiotherapistsRepository, Physiotherapist, PhysiotherapistView, PhysiotherapistData>
    {
        public PhysiotherapistPage(IPhysiotherapistsRepository r) : base(r, "Physiotherapists") { }
        protected internal override Uri pageUrl() => new Uri("/Physiotherapists", UriKind.Relative);
        protected internal override Physiotherapist toObject(PhysiotherapistView v) => new PhysiotherapistViewFacotry().Create(v);
        protected internal override PhysiotherapistView toView(Physiotherapist o) => new PhysiotherapistViewFacotry().Create(o);


        protected override void createTableColumns()
        {
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
