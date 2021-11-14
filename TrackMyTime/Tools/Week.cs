namespace TrackMyTime.Tools
{
    internal static class Week
    {
        public const int NumberOfDays = 7;

        public static List<DateOnly> GetForDate(DateOnly date)
        {
            var dayOfWeek = date.DayOfWeek == DayOfWeek.Sunday ? DayOfWeek.Saturday + 1 : date.DayOfWeek;
            var daysAgoSinceMonday = dayOfWeek - DayOfWeek.Monday;
            var daysUntilSunday = (DayOfWeek.Saturday + 1) - dayOfWeek;

            var weekStart = date.AddDays(-Math.Abs(daysAgoSinceMonday));
            var weekEnd = date.AddDays(Math.Abs(daysUntilSunday));

            List<DateOnly> dateRange = new();

            for (var d = weekStart; d <= weekEnd; d = d.AddDays(1))
            {
                dateRange.Add(d);
            }

            return dateRange;
        }

        public static string GetWeeksSinceDate(DateOnly date)
        {
            if (date == DateOnly.MinValue)
            {
                return "Never";
            }

            var diff = DateTime.UtcNow - date.ToDateTime(TimeOnly.MinValue);
            var timeInWeeks = (int)diff.TotalDays / NumberOfDays;

            return timeInWeeks switch
            {
                0 => "This week",
                1 => "1 week ago",
                _ => $"{timeInWeeks} weeks ago"
            };
        }
    }
}
