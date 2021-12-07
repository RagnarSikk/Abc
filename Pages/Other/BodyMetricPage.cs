using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

namespace Abc.Pages.Other {
    public sealed class BodyMetricPage : ViewPage<BodyMetricPage, IBodyMetricRepository, BodyMetric, BodyMetricView, BodyMetricData>
    {
        public IEnumerable<SelectListItem> Persons { get; }
        public IEnumerable<SelectListItem> BodyMetricTypes { get; }

        public BodyMetricPage(IBodyMetricRepository r, IPersonRepository b, IBodyMetricTypeRepository c) : base(r,
            "Body Metrics")
        {
            Persons = newItemsList<Person, PersonData>(b, null, x => x.FirstMidName + " " + x.LastName);
            BodyMetricTypes = newItemsList<BodyMetricType, BodyMetricTypeData>(c);
        }

        public string PersonName(string id) => itemName(Persons, id);
        public string BodyMetricTypeName(string id) => itemName(BodyMetricTypes, id);

        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Value);
            createColumn(x => Item.BodyMetricTypeId);
            createColumn(x => Item.PersonId);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        

        public override string GetName(IHtmlHelper<BodyMetricPage> h, int i) => i switch
        {
            1 => getName<double>(h,i),
            4 or 5 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<BodyMetricPage> h, int i) => i switch
        {
            1 => getValue<double>(h,i),
            2 => getRaw(h, BodyMetricTypeName(Item.BodyMetricTypeId)),
            3 => getRaw(h, PersonName(Item.PersonId)),
            4 or 5 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };
        protected internal override Uri pageUrl()=> new Uri("/AdminView/BodyMetrics", UriKind.Relative);

        protected internal override BodyMetric toObject(BodyMetricView v) => new BodyMetricViewFactory().Create(v);

        protected internal override BodyMetricView toView(BodyMetric o) => new BodyMetricViewFactory().Create(o);

        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate)
        {
            Item = new BodyMetricView();
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
