namespace TrackMyTime.Services;

public interface IAccruedHoursCalculator
{
    double Calculate(IList<HoursData> data);

    DateOnly GetLastUpdated(IList<HoursData> data);
}