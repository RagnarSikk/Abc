using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq.Expressions;

namespace Abc.Pages {
    public class AdministratorPage : ViewPage<AdministratorPage, IAdministratorsRepository, Administrator, AdministratorView, AdministratorData> {

        public AdministratorPage(IAdministratorsRepository r) : base(r, "Administrators") { }
        protected internal override Uri pageUrl() => new Uri("/Administators", UriKind.Relative);
        protected internal override Administrator toObject(AdministratorView v) => new AdministratorViewFactory().Create(v);
        protected internal override AdministratorView toView(Administrator o) => new AdministratorViewFactory().Create(o);

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
        public override string GetName(IHtmlHelper<AdministratorPage> html, int i) {
            if (i == 1 || i == 2 || i == 4 || i == 5 || i == 6)
                return html.DisplayNameFor(Columns[i] as Expression<Func<AdministratorPage, string>>);
            if (i == 3 || i == 7 || i == 8)
                return html.DisplayNameFor(Columns[i] as Expression<Func<AdministratorPage, DateTime?>>);
            return base.GetName(html, i);
        }
        public override IHtmlContent GetValue(IHtmlHelper<AdministratorPage> html, int i) {
            if (i == 1 || i == 2 || i == 4 || i == 5 || i == 6)
                return html.DisplayFor(Columns[i] as Expression<Func<AdministratorPage, string>>);
            if (i == 3 || i == 7 || i == 8)
                return html.DisplayFor(Columns[i] as Expression<Func<AdministratorPage, DateTime?>>);
            return base.GetValue(html, i);
        }
    }
}
