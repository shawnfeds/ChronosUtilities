using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronosUtilities.BusinessDay
{
    public class BusinessDayCalculator
    {
        public static int CalculateBusinessDays(DateTime startDate, DateTime endDate)
        {
            int businessDays = 0;
            DateTime current = startDate;

            while (current <= endDate)
            {
                if (current.DayOfWeek != DayOfWeek.Saturday && current.DayOfWeek != DayOfWeek.Sunday)
                    businessDays++;
                current = current.AddDays(1);
            }
            return businessDays;
        }
    }

}
