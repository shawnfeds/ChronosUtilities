using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronosUtilities.TimeZoneConversions
{
    public class TimeZoneConverter
    {
        public static DateTime ConvertToTimeZone(DateTime date, string timeZoneId)
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return TimeZoneInfo.ConvertTime(date, timeZone);
        }

        public static DateTime ConvertFromTimeZone(DateTime date, string fromTimeZoneId, string toTimeZoneId)
        {
            TimeZoneInfo fromTimeZone = TimeZoneInfo.FindSystemTimeZoneById(fromTimeZoneId);
            TimeZoneInfo toTimeZone = TimeZoneInfo.FindSystemTimeZoneById(toTimeZoneId);
            DateTime fromTime = TimeZoneInfo.ConvertTime(date, fromTimeZone);
            return TimeZoneInfo.ConvertTime(fromTime, toTimeZone);
        }
    }

}
