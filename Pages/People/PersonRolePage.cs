using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Abc.Pages.People {

    public class PersonRolePage : ViewPage<PersonRolePage, IPersonRoleRepository, PersonRole, PersonRoleView, PersonRoleData> { //public PersonRolePage(IPersonRoleRepository r) : base(r, "PersonRoles") { }
        public IEnumerable<SelectListItem> PersonRoleType { get; }
        public IEnumerable<SelectListItem> Persons { get; }
        public PersonRolePage(IPersonRoleRepository r, IPersonRoleTypeRepository c, IPersonRepository b)
            : base(r, "PersonRoles") {
            PersonRoleType = newItemsList<PersonRoleType, PersonRoleTypeData>(c);
            Persons = newItemsList<Person, PersonData>(b);
        }
        public string CatalogName(string id) => itemName(PersonRoleType, id);
        public string BrandName(string id) => itemName(Persons, id);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.PersonRoleTypeId);
            createColumn(x => Item.PersonId);
            createColumn(x => Item.Certificate);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<PersonRolePage> html, int i) {
            if (i == 4 || i == 5)
                return html.DisplayNameFor(Columns[i] as Expression<Func<PersonRolePage, DateTime?>>);
            return base.GetName(html, i);
        }
        public override IHtmlContent GetValue(IHtmlHelper<PersonRolePage> html, int i) {
            if (i == 4 || i == 5)
                return html.DisplayFor(Columns[i] as Expression<Func<PersonRolePage, DateTime?>>);
            return base.GetValue(html, i);
        }

        protected internal override Uri pageUrl() => new Uri("/AdminView/PersonRoles", UriKind.Relative);

        protected internal override PersonRole toObject(PersonRoleView v) => new PersonRoleViewFactory().Create(v);

        protected internal override PersonRoleView toView(PersonRole o) => new PersonRoleViewFactory().Create(o);

        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new PersonRoleView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
