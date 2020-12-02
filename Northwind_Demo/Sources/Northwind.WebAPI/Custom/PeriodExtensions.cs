using System;

namespace Northwind.WebAPI.Custom
{
    public static class PeriodExtensions
    {
        public static void TestIntevals()
        {
            var result = GetIntervals(new DateTime(2018, 7, 16), new DateTime(2018, 7, 22), 8);
        }

        public static Interval[] GetIntervals(DateTime startDate, DateTime endDate, int periodQuantity)
        {
            startDate = startDate.Date;
            endDate = endDate.Date;

            //NOTE: Make 1 day shift for future condition startDate<= date and date<EndDate
            var period = endDate.Subtract(startDate).Days+1;

            var result = new Interval[periodQuantity];
            var date = startDate.AddDays(period);
            for (var i = 0; i < periodQuantity; i++)
            {
                var sdate = date.AddDays(-period);
                result[i] = new Interval(sdate, date, date.AddDays(-1));
                date = sdate;
            }

            return result;
        }
    }

    public sealed class Interval
    {
        public Interval(DateTime start, DateTime end, DateTime displayEnd)
        {
            Start = start;
            End = end;
            DisplayEnd = displayEnd;
        }

        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public DateTime DisplayEnd { get; private set; }

        public override string ToString()
        {
            return string.Format("{0:yy-MMM-dd} <= date < {1:yy-MMM-dd}", Start, End);
        }
    }
}