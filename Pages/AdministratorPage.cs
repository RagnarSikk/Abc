using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Infra;
using Abc.Pages.Common;
using System;

namespace Abc.Pages {
    public class AdministratorPage : ViewPage<AdministratorPage, IAdministratorsRepository, Administrator, AdministratorView, AdministratorData> {
      
        public AdministratorPage(IAdministratorsRepository r) : base(r, "Administrators") { }
        protected internal override Uri pageUrl() => new Uri("/Administators", UriKind.Relative);
        protected internal override Administrator toObject(AdministratorView v) => new AdministratorViewFacotry().Create(v);
        protected internal override AdministratorView toView(Administrator o) => new AdministratorViewFacotry().Create(o);

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.LastName);
            createColumn(x => Item.FirstMidName);
            createColumn(x => Item.DateOfBirth);
            createColumn(x => Item.Gender);
            createColumn(x => Item.PhoneNumber);
            createColumn(x => Item.Email);
        }
    }
}
