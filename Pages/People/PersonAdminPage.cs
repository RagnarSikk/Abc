using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq.Expressions;

namespace Abc.Pages.People {
    public abstract class PersonAdminPage<TPage>
        : ViewPage<TPage, IPersonRepository, Person, PersonView, PersonData>
        where TPage : PageModel {
        protected PersonAdminPage(IPersonRepository r) : base(r, "Persons") { }
        protected internal override Uri pageUrl() => new Uri("/AdminView/Persons", UriKind.Relative);
        protected internal override Person toObject(PersonView v) => new PersonViewFactory().Create(v);
        protected internal override PersonView toView(Person o) => new PersonViewFactory().Create(o);
        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.LastName);
            createColumn(x => Item.FirstMidName);
            createColumn(x => Item.PhoneNumber);
            createColumn(x => Item.Email);
            createColumn(x => Item.Gender);
            createColumn(x => Item.DateOfBirth);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<TPage> html, int i) {
            if (i == 6 || i == 7 || i == 8)
                return html.DisplayNameFor(Columns[i] as Expression<Func<TPage, DateTime?>>);
            return base.GetName(html, i);
        }

        public override IHtmlContent GetValue(IHtmlHelper<TPage> html, int i) {
            if (i == 6 || i == 7 || i == 8)
                return html.DisplayFor(Columns[i] as Expression<Func<TPage, DateTime?>>);
            return base.GetValue(html, i);
        }

        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new PersonView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
