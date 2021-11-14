using TrackMyTime.Tools;

namespace TrackMyTime.Services
{
    internal class AccruedHoursCalculator : IAccruedHoursCalculator
    {
        private const int ExpectedHoursPerWeek = 40;

        public double Calculate(IList<HoursData> data)
        {
            if (data is null || !data.Any()) return 0;

            var sortedData = data.OrderBy(d => d.Date).ToList();
            var minDate = sortedData.First();
            var maxDate = sortedData.Last();

            var daySpan = maxDate.Date.ToDateTime(TimeOnly.MinValue) - minDate.Date.ToDateTime(TimeOnly.MinValue);

            var weekSpan = (int)(daySpan.TotalDays / Week.NumberOfDays) + 1;

            var expectedHoursWorked = weekSpan * ExpectedHoursPerWeek;

            return sortedData.Sum(x => x.Hour) - expectedHoursWorked;
        }

        public DateOnly GetLastUpdated(IList<HoursData> data)
        {
            if (data is null || !data.Any()) return DateOnly.MinValue;

            return data.OrderByDescending(d => d.Date).First().Date;
        }
    }
}
