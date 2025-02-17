using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronosUtilities.Calculations
{
    public class DateCalculations
    {
        public static DateTime AddDays(DateTime date, int days) => date.AddDays(days);
        public static DateTime SubtractDays(DateTime date, int days) => date.AddDays(-days);

        public static DateTime AddWeeks(DateTime date, int weeks) => date.AddDays(weeks * 7);
        public static DateTime SubtractWeeks(DateTime date, int weeks) => date.AddDays(-weeks * 7);

        public static DateTime AddMonths(DateTime date, int months) => date.AddMonths(months);
        public static DateTime SubtractMonths(DateTime date, int months) => date.AddMonths(-months);

        public static DateTime AddYears(DateTime date, int years) => date.AddYears(years);
        public static DateTime SubtractYears(DateTime date, int years) => date.AddYears(-years);
    }

}
