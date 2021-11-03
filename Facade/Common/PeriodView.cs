using Abc.Data.Common;
using Abc.Domain.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Common {

    public abstract class PeriodView :BaseEntity {

        internal static string setDisplayNameValue => "set_DisplayNameValue";

        [DataType(DataType.Date)]
        [DisplayName("Valid From")]
        public DateTime? From { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Valid To")]
        public DateTime? To { get; set; }

        public abstract string GetId();

    }
}