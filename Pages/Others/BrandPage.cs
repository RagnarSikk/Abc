using Abc.Domain.Others.Repositories;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Abc.Pages.Others {
    [Authorize]
    public sealed class BrandPage : BrandBasePage<BrandPage> {
        public BrandPage(IBrandRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new Uri("/AdminView/Brand", UriKind.Relative);
    }

}
