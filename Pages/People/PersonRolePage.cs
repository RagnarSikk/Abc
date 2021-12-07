using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Abc.Domain.People.Repositories;
using Abc.Facade.People.Factories;

namespace Abc.Pages.People {

    public class PersonRolePage : ViewPage<PersonRolePage, IPersonRoleRepository, PersonRole, PersonRoleView,
        PersonRoleData>
    {
        public IEnumerable<SelectListItem> PersonRoleTypes { get; }
        public IEnumerable<SelectListItem> Persons { get; }


        public PersonRolePage(IPersonRoleRepository r, IPersonRoleTypeRepository c, IPersonRepository b)
            : base(r, "PersonRoles")
        {
            PersonRoleTypes = newItemsList<PersonRoleType, PersonRoleTypeData>(c);
            Persons = newItemsList<Person, PersonData>(b,null, x=>x.FirstMidName+ " "+ x.LastName);
        }

        public string PersonRoleTypeName(string id) => itemName(PersonRoleTypes, id);
        public string PersonName(string id) => itemName(Persons, id);


        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.PersonRoleTypeId);
            createColumn(x => Item.PersonId);
            createColumn(x => Item.Certificate);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }

        public override string GetName(IHtmlHelper<PersonRolePage> h, int i) => i switch
        {
            4 or 5 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<PersonRolePage> h, int i) => i switch
        {
            1 => getRaw(h, PersonRoleTypeName(Item.PersonRoleTypeId)),
            2 => getRaw(h, PersonName(Item.PersonId)),
            4 or 5 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };

        protected internal override Uri pageUrl() => new Uri("/AdminView/PersonRoles", UriKind.Relative);

        protected internal override PersonRole toObject(PersonRoleView v) => new PersonRoleViewFactory().Create(v);

        protected internal override PersonRoleView toView(PersonRole o) => new PersonRoleViewFactory().Create(o);

        public override IActionResult OnGetCreate(
            
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate)
        {
            Item = new PersonRoleView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }

    }
}
