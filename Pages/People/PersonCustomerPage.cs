using Abc.Domain.People.Repositories;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Abc.Pages.People {
    public sealed class PersonCustomerPage : PersonAdminPage<PersonCustomerPage> {
        public PersonCustomerPage(IPersonRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new Uri("/Customers/Persons", UriKind.Relative);
        protected override void createTableColumns() {
            createColumn(x => Item.LastName);
            createColumn(x => Item.FirstMidName);
            createColumn(x => Item.PhoneNumber);
            createColumn(x => Item.Email);
            createColumn(x => Item.DateOfBirth);
        }
        public override string GetName(IHtmlHelper<PersonCustomerPage> h, int i) => i switch {
            4 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<PersonCustomerPage> h, int i) => i switch {
            4 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
