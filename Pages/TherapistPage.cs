using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Infra;
using Abc.Pages.Common;
using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Abc.Pages {
    public class TherapistPage : ViewPage<TherapistPage, ITherepistsRepository, Therapist, TherapistView, TherapistData>
    {
        public TherapistPage(ITherepistsRepository r) : base(r, "Therapists") { }
        protected internal override Uri pageUrl() => new Uri("/Therapists", UriKind.Relative);
        protected internal override Therapist toObject(TherapistView v) => new TherapistViewFactory().Create(v);
        protected internal override TherapistView toView(Therapist o) => new TherapistViewFactory().Create(o);


        protected override void createTableColumns()
        {
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
        public override string GetName(IHtmlHelper<TherapistPage> html, int i)
        {
            if (i == 1 || i == 2 || i == 4 || i == 5 || i == 6)
                return html.DisplayNameFor(Columns[i] as Expression<Func<TherapistPage, string>>);
            if (i == 3 || i == 7 || i == 8)
                return html.DisplayNameFor(Columns[i] as Expression<Func<TherapistPage, DateTime?>>);
            return base.GetName(html, i);
        }
        public override IHtmlContent GetValue(IHtmlHelper<TherapistPage> html, int i)
        {
            if (i == 1 || i == 2 || i == 4 || i == 5 || i == 6)
                return html.DisplayFor(Columns[i] as Expression<Func<TherapistPage, string>>);
            if (i == 3 || i == 7 || i == 8)
                return html.DisplayFor(Columns[i] as Expression<Func<TherapistPage, DateTime?>>);
            return base.GetValue(html, i);
        }
    }
}
