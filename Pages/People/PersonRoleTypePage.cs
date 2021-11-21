using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq.Expressions;

namespace Abc.Pages.People {
    public class PersonRoleTypePage : ViewPage<PersonRoleTypePage, IPersonRoleTypeRepository, PersonRoleType, PersonRoleTypeView, PersonRoleTypeData> {
        public PersonRoleTypePage(IPersonRoleTypeRepository r) : base(r, "PersonRoleTypes") { }
        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Code);
            createColumn(x => Item.Definition);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<PersonRoleTypePage> html, int i) {
            if (i == 4 || i == 5)
                return html.DisplayNameFor(Columns[i] as Expression<Func<PersonRoleTypePage, DateTime?>>);
            return base.GetName(html, i);
        }
        public override IHtmlContent GetValue(IHtmlHelper<PersonRoleTypePage> html, int i) {
            if (i == 4 || i == 5)
                return html.DisplayFor(Columns[i] as Expression<Func<PersonRoleTypePage, DateTime?>>);
            return base.GetValue(html, i);
        }

        protected internal override Uri pageUrl() => new Uri("/AdminView/PersonRoleTypes", UriKind.Relative);

        protected internal override PersonRoleType toObject(PersonRoleTypeView v) => new PersonRoleTypeViewFactory().Create(v);

        protected internal override PersonRoleTypeView toView(PersonRoleType o) => new PersonRoleTypeViewFactory().Create(o);

        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new PersonRoleTypeView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
