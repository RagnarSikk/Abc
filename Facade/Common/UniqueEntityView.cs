using System;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Common {

    public abstract class UniqueEntityView : PeriodView {
        protected UniqueEntityView() => Id = Guid.NewGuid().ToString();
        [Required] public string Id { get; set; }
        public override string GetId() => Id;
    }
}