using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Others;
using Abc.Domain.Others.Repositories;
using Abc.Domain.People;
using Abc.Domain.People.Repositories;
using Abc.Facade.Others;
using Abc.Facade.Others.Factories;
using Abc.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Abc.Pages.Others
{
    public class BrandPage : BrandBasePage<BrandPage>
    {
        public BrandPage(IBrandRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new Uri("/AdminView/Brand", UriKind.Relative);
    }

}
