using System;

namespace Abc.Domain.Common {
    //TODO G: Why these values? 02.11.2020 
    public abstract class BaseEntity {
        public static string Unspecified => Aids.Constants.Word.Unspecified;
        public static DateTime UnspecifiedValidFrom => DateTime.MinValue;
        public static DateTime UnspecifiedValidTo => DateTime.MaxValue;
        public static double UnspecifiedDouble => double.NaN;
        public static decimal UnspecifiedDecimal => decimal.MaxValue;
        public static int UnspecifiedInteger => 0;
    }
}