using System;
using System.Linq.Expressions;
using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.Other;
using Abc.Facade.People;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.People
{
    public class PersonPage : ViewPage<PersonPage, IPersonRepository, Person, PersonView, PersonData>
    {
        public PersonPage(IPersonRepository r) : base(r, "Persons")
        {
        }

        protected override void createTableColumns()
        {
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
        public override string GetName(IHtmlHelper<PersonPage> html, int i)
        {
            if (i == 6 || i == 7|| i==8)
                return html.DisplayNameFor(Columns[i] as Expression<Func<PersonPage, DateTime?>>);
            return base.GetName(html, i);
        }
        public override IHtmlContent GetValue(IHtmlHelper<PersonPage> html, int i)
        {
            if (i == 6 || i == 7|| i==8)
                return html.DisplayFor(Columns[i] as Expression<Func<PersonPage, DateTime?>>);
            return base.GetValue(html, i);
        }

        protected internal override Uri pageUrl() => new Uri("/AdminView/Persons", UriKind.Relative);
        protected internal override Person toObject(PersonView v) => new PersonViewFactory().Create(v);

        protected internal override PersonView toView(Person o) => new PersonViewFactory().Create(o);

        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate)
        {
            Item = new PersonView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
