﻿using System;
using System.Linq.Expressions;
using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.People
{

    public class PersonRolePage : ViewPage<PersonRolePage, IPersonRoleRepository, PersonRole, PersonRoleView, PersonRoleData>
    {
        public PersonRolePage(IPersonRoleRepository r) : base(r, "PersonRoles") { }
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.PersonRoleTypeId);
            createColumn(x => Item.PersonId);
            createColumn(x => Item.Certificate);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<PersonRolePage> html, int i)
        {
            if (i == 4 || i == 5)
                return html.DisplayNameFor(Columns[i] as Expression<Func<PersonRolePage, DateTime?>>);
            return base.GetName(html, i);
        }
        public override IHtmlContent GetValue(IHtmlHelper<PersonRolePage> html, int i)
        {
            if (i == 4 || i == 5)
                return html.DisplayFor(Columns[i] as Expression<Func<PersonRolePage, DateTime?>>);
            return base.GetValue(html, i);
        }

        protected internal override Uri pageUrl() => new Uri("/AdminView/PersonRoles", UriKind.Relative);

        protected internal override PersonRole toObject(PersonRoleView v) => new PersonRoleViewFactory().Create(v);

        protected internal override PersonRoleView toView(PersonRole o) => new PersonRoleViewFactory().Create(o);
    }
}
