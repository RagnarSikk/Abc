using Abc.Domain.People;
using Abc.Facade.People;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Abc.Pages.People {
    public sealed class PersonCustomerPage : PersonAdminPage<PersonCustomerPage> {
        public PersonCustomerPage(IPersonRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new Uri("/Customers/Persons", UriKind.Relative);
        protected override void createTableColumns() {
            createColumn(x => Item.Id); //Todo: sellest peaks lahti saama 
            createColumn(x => Item.LastName);
            createColumn(x => Item.FirstMidName);
            createColumn(x => Item.PhoneNumber);
            createColumn(x => Item.Email);
            createColumn(x => Item.Gender);
            createColumn(x => Item.DateOfBirth);
        }

        public override async Task OnGetIndexAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue) {
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue).ConfigureAwait(true);
        }
        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate) {
            Item = new PersonView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
