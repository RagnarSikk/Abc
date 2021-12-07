﻿using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Common;

namespace Abc.Facade.Others
{
    public class BodyMetricTypeViewFactory : AbstractViewFactory<BodyMetricTypeData, BodyMetricType, BodyMetricTypeView>
    {
        protected internal override BodyMetricType toObject(BodyMetricTypeData d) => new(d);
    }
}
