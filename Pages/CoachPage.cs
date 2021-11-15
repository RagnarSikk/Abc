using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Infra;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq.Expressions;

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
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<CoachPage> html, int i)
        {
            if (i == 1 || i == 2 || i == 4 || i == 5 || i == 6)
                return html.DisplayNameFor(Columns[i] as Expression<Func<CoachPage, string>>);
            if (i == 3 || i == 7 || i == 8)
                return html.DisplayNameFor(Columns[i] as Expression<Func<CoachPage, DateTime?>>);
            return base.GetName(html, i);
        }
        public override IHtmlContent GetValue(IHtmlHelper<CoachPage> html, int i)
        {
            if (i == 1 || i == 2 || i == 4 || i == 5 || i == 6)
                return html.DisplayFor(Columns[i] as Expression<Func<CoachPage, string>>);
            if (i == 3 || i == 7 || i == 8)
                return html.DisplayFor(Columns[i] as Expression<Func<CoachPage, DateTime?>>);
            return base.GetValue(html, i);
        }
    }
}
