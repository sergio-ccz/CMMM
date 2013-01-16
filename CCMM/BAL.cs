using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCMM
{
    class BAL
    {
        public static List<string> CreateWeekEntries()
        {
            List<string> yearWeeks = new List<string>();

            for (int i = 1; i < 53; i++)
            {
                DateTime[] tempWeek = WeekDays(DateTime.Now.Year, i);
                yearWeeks.Add("[" + DateTime.Now.Year + "]" + "Semana #" + i + " " + tempWeek[0].ToShortDateString() + " - " + tempWeek[6].ToShortDateString());
            }

            return yearWeeks;
        }

        private static DateTime[] WeekDays(int Year, int WeekNumber)
        {
            DateTime start = new DateTime(Year, 1, 4);
            start = start.AddDays(-((int)start.DayOfWeek));
            start = start.AddDays(7 * (WeekNumber - 1));
            return Enumerable.Range(0, 7).Select(num => start.AddDays(num)).ToArray();
        }
    }
}
