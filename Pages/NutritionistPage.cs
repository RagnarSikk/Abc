using Abc.Data.People;
using Abc.Domain.People;
using Abc.Facade.People;
using Abc.Infra;
using Abc.Pages.Common;
using System;

namespace Abc.Pages {
    public class NutritionistPage : ViewPage<NutritionistPage, INutritionistsRepository, Nutritionist, NutritionistView, NutritionistData>
    {
        public NutritionistPage(INutritionistsRepository r) : base(r, "Nutritionists") { }
        protected internal override Uri pageUrl() => new Uri("/Nutritionists", UriKind.Relative);
        protected internal override Nutritionist toObject(NutritionistView v) => new NutritionistViewFacotry().Create(v);
        protected internal override NutritionistView toView(Nutritionist o) => new NutritionistViewFacotry().Create(o);


        protected override void createTableColumns()
        {
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
