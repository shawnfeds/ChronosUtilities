using System;
using NUnit.Framework;
using ChronosUtilities.Calculations;
using NUnit.Framework.Legacy;

namespace ChronosUtilities.Tests
{
    [TestFixture]
    public class DateCalculationsTests
    {
        [Test]
        public void AddDays_ShouldReturnCorrectDate()
        {
            DateTime date = new DateTime(2023, 1, 1);
            DateTime expected = new DateTime(2023, 1, 6);
            DateTime result = DateCalculations.AddDays(date, 5);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void SubtractDays_ShouldReturnCorrectDate()
        {
            DateTime date = new DateTime(2023, 1, 10);
            DateTime expected = new DateTime(2023, 1, 5);
            DateTime result = DateCalculations.SubtractDays(date, 5);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void AddWeeks_ShouldReturnCorrectDate()
        {
            DateTime date = new DateTime(2023, 1, 1);
            DateTime expected = new DateTime(2023, 1, 22);
            DateTime result = DateCalculations.AddWeeks(date, 3);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void SubtractWeeks_ShouldReturnCorrectDate()
        {
            DateTime date = new DateTime(2023, 1, 22);
            DateTime expected = new DateTime(2023, 1, 1);
            DateTime result = DateCalculations.SubtractWeeks(date, 3);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void AddMonths_ShouldReturnCorrectDate()
        {
            DateTime date = new DateTime(2023, 1, 1);
            DateTime expected = new DateTime(2023, 4, 1);
            DateTime result = DateCalculations.AddMonths(date, 3);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void SubtractMonths_ShouldReturnCorrectDate()
        {
            DateTime date = new DateTime(2023, 4, 1);
            DateTime expected = new DateTime(2023, 1, 1);
            DateTime result = DateCalculations.SubtractMonths(date, 3);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void AddYears_ShouldReturnCorrectDate()
        {
            DateTime date = new DateTime(2023, 1, 1);
            DateTime expected = new DateTime(2028, 1, 1);
            DateTime result = DateCalculations.AddYears(date, 5);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void SubtractYears_ShouldReturnCorrectDate()
        {
            DateTime date = new DateTime(2028, 1, 1);
            DateTime expected = new DateTime(2023, 1, 1);
            DateTime result = DateCalculations.SubtractYears(date, 5);
            ClassicAssert.AreEqual(expected, result);
        }
    }
}
