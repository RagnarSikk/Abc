using Abc.Data.People;
using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Domain.People
{
    public sealed class Nutritionist : Person<NutritionistData>
    {
        public Nutritionist(NutritionistData d) : base(d) { }


    }
}
