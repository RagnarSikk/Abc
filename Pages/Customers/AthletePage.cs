using Abc.Data.Customers;
using Abc.Domain.Customers;
using Abc.Facade.Customers;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq.Expressions;

namespace Abc.Pages.Customers {
    public class AthletePage : ViewPage<AthletePage, IAthletesRepository, Athlete, AthleteView, AthleteData> {
        public AthletePage(IAthletesRepository r) : base(r, "Athletes") { }
        protected internal override Uri pageUrl() => new Uri("/Customers/Athletes", UriKind.Relative);
        protected internal override Athlete toObject(AthleteView v) => new AthleteViewFactory().Create(v);
        protected internal override AthleteView toView(Athlete o) => new AthleteViewFactory().Create(o);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.LastName);
            createColumn(x => Item.FirstMidName);
            createColumn(x => Item.DateOfBirth);
            createColumn(x => Item.Gender);
            createColumn(x => Item.PhoneNumber);
            createColumn(x => Item.Email);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
            createColumn(x => Item.Weight);
            createColumn(x => Item.Height);
            createColumn(x => Item.AmountOfVisits);
        }
        public override string GetName(IHtmlHelper<AthletePage> html, int i) {
            if (i == 1 || i == 2 || i == 4 || i == 5 || i == 6)
                return html.DisplayNameFor(Columns[i] as Expression<Func<AthletePage, string>>);
            if (i == 3 || i == 7 || i == 8)
                return html.DisplayNameFor(Columns[i] as Expression<Func<AthletePage, DateTime?>>);
            if (i == 9 || i == 10)
                return html.DisplayNameFor(Columns[i] as Expression<Func<AthletePage, double>>);
            if (i == 11)
                return html.DisplayNameFor(Columns[i] as Expression<Func<AthletePage, int>>);
            return base.GetName(html, i);

        }
        public override IHtmlContent GetValue(IHtmlHelper<AthletePage> html, int i) {
            if (i == 1 || i == 2 || i == 4 || i == 5 || i == 6)
                return html.DisplayFor(Columns[i] as Expression<Func<AthletePage, string>>);
            if (i == 3 || i == 7 || i == 8)
                return html.DisplayFor(Columns[i] as Expression<Func<AthletePage, DateTime?>>);
            if (i == 9 || i == 10)
                return html.DisplayFor(Columns[i] as Expression<Func<AthletePage, double>>);
            if (i == 11)
                return html.DisplayFor(Columns[i] as Expression<Func<AthletePage, int>>);
            return base.GetValue(html, i);
        }
    }
}
