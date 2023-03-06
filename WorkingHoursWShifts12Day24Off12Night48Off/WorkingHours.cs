using System;

namespace WorkingHoursWShifts12Day24Off12Night48Off
{
    public class WorkingHours
    {
        private DateTime _startDate;
        private WorkingType _currentSchedule;

        public WorkingHours(DateTime startDate)
        {
            _startDate = startDate;
            _currentSchedule = WorkingType.Day;
        }

        /// <summary>
        /// It checks the intervals, based on the formula: Working 12 hours during the day, rest 24 hours, working 12h night and rest for the 48h.
        /// </summary>
        /// <param name="dateToCheck"></param>
        /// <returns>workingType on that specific date</returns>
        public WorkingType GetWorkingType(DateTime dateToCheck)
        {
            var elapsedDays = (dateToCheck - _startDate).Days;
            var totalPeriods = elapsedDays / 4; // 4-cycle of working period 
            var remainingDays = elapsedDays % 4;

            switch (_currentSchedule)
            {
                case WorkingType.Day:
                    if (remainingDays < 1)
                    {
                        _currentSchedule = WorkingType.Day;
                    }
                    else if (remainingDays < 2)
                    {
                        _currentSchedule = WorkingType.Night;
                    }
                    else if (remainingDays < 4)
                    {
                        _currentSchedule = WorkingType.Off;
                    }
                    break;
                case WorkingType.Night:
                    if (remainingDays < 2)
                    {
                        _currentSchedule = WorkingType.Night;
                    }
                    else
                    {
                        _currentSchedule = WorkingType.Off;
                    }
                    break;
                case WorkingType.Off:
                    if (remainingDays < 1)
                    {
                        _currentSchedule = WorkingType.Day;
                    }
                    else if (remainingDays < 3)
                    {
                        _currentSchedule = WorkingType.Off;
                    }
                    else
                    {
                        _currentSchedule = WorkingType.Night;
                    }
                    break;
            }

            return _currentSchedule;
        }
    }
}
