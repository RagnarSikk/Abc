using Abc.Data;
using Abc.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Pages {
    public class AdministratorPage : AbstractPage<AdministratorPage, AdminstratorData> {
        public AdministratorPage(TrainingDbContext c) : base(c, c.Administrators) {
            Caption = "Administrators";
        }
        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.AdministartorId);
        }
    }
    public class AthletePage : AbstractPage<AthletePage, AthleteData> {
        public AthletePage(TrainingDbContext c) : base(c, c.Athletes) {
            Caption = "Athletes";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Weight);
            createColumn(x => Item.Height);
            createColumn(x => Item.AmountOfVisits);
        }
    }
    public class CoachPage : AbstractPage<CoachPage, CoachData> {
        public CoachPage(TrainingDbContext c) : base(c, c.Coaches) {
            Caption = "Coaches";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
        }
    }
    public class EquipmentPage : AbstractPage<EquipmentPage, EquipmentData> {
        public EquipmentPage(TrainingDbContext c) : base(c, c.Equipments) {
            Caption = "Equipments";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Description);
            createColumn(x => Item.AmountAvailable);
            createColumn(x => Item.AmountInUsing);
        }
    }
    public class NutritionistPage : AbstractPage<NutritionistPage, NutritionistData> {
        public NutritionistPage(TrainingDbContext c) : base(c, c.Nutritionists) {
            Caption = "Nutritionists";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            
        }
    }
    public class PhysiotherapistPage : AbstractPage<PhysiotherapistPage, PhysiotherapistData> {
        public PhysiotherapistPage(TrainingDbContext c) : base(c, c.Physiotherapists) {
            Caption = "Physiotherapist";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);

        }
    }
    public class TherapistPage : AbstractPage<TherapistPage, TherapistData> {
        public TherapistPage(TrainingDbContext c) : base(c, c.Therapists) {
            Caption = "Therapist";
        }

        protected override void createTableColumns() {
            createColumn(x => Item.Id);

        }
    }
}
