using NUnit.Framework;
using System;
using WorkingHoursWShifts12Day24Off12Night48Off;

namespace WorkingHours12shift.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        } 

        [TestCase("2022-12-30", "2023-03-04", WorkingType.Day)]
        [TestCase("2023-03-04", "2023-03-04", WorkingType.Day)]
        [TestCase("2023-03-04", "2023-03-05", WorkingType.Night)]
        [TestCase("2023-03-04", "2023-03-06", WorkingType.Off)]
        [TestCase("2023-03-04", "2023-03-07", WorkingType.Off)]
        [TestCase("2023-03-04", "2023-03-08", WorkingType.Day)]
        [TestCase("2023-03-04", "2023-03-09", WorkingType.Night)]
        [TestCase("2023-03-04", "2023-12-30", WorkingType.Night)]
        [TestCase("2023-03-04", "2023-12-31", WorkingType.Off)]
        [TestCase("2023-03-04", "2024-01-01", WorkingType.Off)]
        [TestCase("2023-03-04", "2024-01-02", WorkingType.Day)]
        [TestCase("2023-03-04", "2024-01-03", WorkingType.Night)]
        public void TestWorkingHours(DateTime startDate, DateTime date2Check, int expectedResult)
        {
            // Arrange
            WorkingHours workingHours = new WorkingHours(startDate);

            // Act
            int result = (int)workingHours.GetWorkingType(date2Check);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [TestCase("2022-12-30", "2023-03-04", WorkingType.Day)]
        [TestCase("2023-03-04", "2023-03-04", WorkingType.Day)]
        [TestCase("2023-03-04", "2023-03-05", WorkingType.Night)]
        [TestCase("2023-03-04", "2023-03-06", WorkingType.Off)]
        [TestCase("2023-03-04", "2023-03-07", WorkingType.Off)]
        [TestCase("2023-03-04", "2023-03-08", WorkingType.Day)]
        [TestCase("2023-03-04", "2023-03-09", WorkingType.Night)]
        [TestCase("2023-03-04", "2023-12-30", WorkingType.Night)]
        [TestCase("2023-03-04", "2023-12-31", WorkingType.Off)]
        [TestCase("2023-03-04", "2024-01-01", WorkingType.Off)]
        [TestCase("2023-03-04", "2024-01-02", WorkingType.Day)]
        [TestCase("2023-03-04", "2024-01-03", WorkingType.Night)]
        public void TestWorkingHours_SecFunct(DateTime startDate, DateTime date2Check, int expectedResult)
        {
            // Arrange
            WorkingHours workingHours = new WorkingHours(startDate);

            // Act
            int result = (int)workingHours.GetWorkingType(startDate, date2Check);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

    }
}