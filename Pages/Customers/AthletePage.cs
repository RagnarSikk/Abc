using System;
using Abc.Data.Customers;
using Abc.Domain.Customers;
using Abc.Facade.Customers;
using Abc.Pages.Common;

namespace Abc.Pages.Customers
{
    public class AthletePage : ViewPage<AthletePage,IAthletesRepository,Athlete, AthleteView, AthleteData> {
        public AthletePage(IAthletesRepository r) : base(r,"Athletes") { }
        protected internal override Uri pageUrl() => new Uri("/Customers/Athletes", UriKind.Relative);
        protected internal override Athlete toObject(AthleteView v) => new AthleteViewFactory().Create(v);
        protected internal override AthleteView toView(Athlete o) => new AthleteViewFactory().Create(o);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Weight);
            createColumn(x => Item.Height);
            createColumn(x => Item.AmountOfVisits);
        }
    }
}
