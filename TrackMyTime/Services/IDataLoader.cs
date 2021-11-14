namespace TrackMyTime.Services;

public interface IDataLoader
{
    List<HoursData> GetData();
    void Save(List<HoursData> data);
}