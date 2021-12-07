using Abc.Data.Others;
using Abc.Domain.Others;
using Abc.Facade.Others;
using Abc.Pages.Common;
using System;
using Abc.Domain.Others.Repositories;
using Abc.Facade.Others.Factories;

namespace Abc.Pages {
    public class TrainingPage : ViewPage<TrainingPage, ITrainingRepository, Training, TrainingView, TrainingData> {
        public TrainingPage(ITrainingRepository r) : base(r, "Trainings") { }
        protected internal override Uri pageUrl() => new Uri("/Trainings", UriKind.Relative);
        protected internal override Training toObject(TrainingView v) => new TrainingViewFactory().Create(v);
        protected internal override TrainingView toView(Training o) => new TrainingViewFactory().Create(o);


        protected override void createTableColumns() {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Definition);
            createColumn(x => Item.AvailableEquipment);
            createColumn(x => Item.LocationOfTraining);
            createColumn(x => Item.MaxNumberOfAthletes);
            createColumn(x => Item.MinNumberOfAthletes);
            createColumn(x => Item.NumberOfAthletes);
            createColumn(x => Item.NumberOfCoachesRequired);
        }
    }
}
