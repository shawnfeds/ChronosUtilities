using System;
using NUnit.Framework;
using ChronosUtilities.BusinessDay;
using NUnit.Framework.Legacy;

namespace ChronosUtilities.Tests
{
    [TestFixture]
    public class BusinessDayCalculatorTests
    {
        [Test]
        public void CalculateBusinessDays_ShouldReturnCorrectCount()
        {
            DateTime startDate = new DateTime(2023, 1, 1);
            DateTime endDate = new DateTime(2023, 1, 10);
            int result = BusinessDayCalculator.CalculateBusinessDays(startDate, endDate);
            int expected = 7; // 7 business days excluding weekends
            ClassicAssert.AreEqual(expected, result);
        }
    }
}
