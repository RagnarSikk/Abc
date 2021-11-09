﻿using Abc.Data.People;
using Abc.Infra;

namespace Abc.Pages {
    public class AdministratorPage : AbstractPage<AdministratorPage, AdministratorData> {
        public AdministratorPage(TrainingDbContext c) : base(c, c.Administrators) {
            Caption = "Administrators";
        }
        protected override void createTableColumns() {
            createColumn(x => Item.Id);
        }
    }
}
