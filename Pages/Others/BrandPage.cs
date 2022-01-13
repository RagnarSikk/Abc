using Abc.Domain.Others.Repositories;
using System;

namespace Abc.Pages.Others {
    public class BrandPage : BrandBasePage<BrandPage> {
        public BrandPage(IBrandRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new Uri("/AdminView/Brand", UriKind.Relative);
    }

}
