using System;
using NUnit.Framework;
using ChronosUtilities.TimeZoneConversions;
using NUnit.Framework.Legacy;

namespace ChronosUtilities.Tests
{
    [TestFixture]
    public class TimeZoneConverterTests
    {
        [Test]
        public void ConvertToTimeZone_ShouldReturnCorrectDateTime()
        {
            DateTime date = new DateTime(2023, 1, 1, 12, 0, 0);
            string timeZoneId = "Pacific Standard Time";
            DateTime result = TimeZoneConverter.ConvertToTimeZone(date, timeZoneId);
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            DateTime expected = TimeZoneInfo.ConvertTime(date, timeZone);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void ConvertFromTimeZone_ShouldReturnCorrectDateTime()
        {
            DateTime date = new DateTime(2023, 1, 1, 12, 0, 0);
            string fromTimeZoneId = "Pacific Standard Time";
            string toTimeZoneId = "Eastern Standard Time";
            DateTime result = TimeZoneConverter.ConvertFromTimeZone(date, fromTimeZoneId, toTimeZoneId);
            TimeZoneInfo fromTimeZone = TimeZoneInfo.FindSystemTimeZoneById(fromTimeZoneId);
            TimeZoneInfo toTimeZone = TimeZoneInfo.FindSystemTimeZoneById(toTimeZoneId);
            DateTime fromTime = TimeZoneInfo.ConvertTime(date, fromTimeZone);
            DateTime expected = TimeZoneInfo.ConvertTime(fromTime, toTimeZone);
            ClassicAssert.AreEqual(expected, result);
        }
    }
}
