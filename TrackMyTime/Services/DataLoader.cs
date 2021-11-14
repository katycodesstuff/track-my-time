using System.Text;

namespace TrackMyTime.Services
{
    internal class DataLoader : IDataLoader
    {
        private const string FileName = "trackMyTimeSaved.txt";
        private readonly string[] _savedData;

        public DataLoader()
        {
            if (!File.Exists(FileName))
            {
                using var file = File.Create(FileName);
            }

            _savedData = File.ReadAllLines(FileName);
        }

        public List<HoursData> GetData()
        {
            return Parse();
        }

        public void Save(List<HoursData> data)
        {
            var serialisedData = Serialise(data);
            var tempFileName = Path.GetTempFileName();
            File.WriteAllText(tempFileName, serialisedData);
            File.Move(tempFileName, FileName, true);
        }

        private List<HoursData> Parse()
        {
            var list = new List<HoursData>();

            foreach (var line in _savedData)
            {
                var data = line.Split('|');
                if (data.Length != 2) continue;

                if (!double.TryParse(data[0], out var hour) | !DateOnly.TryParseExact(data[1], "yyyyMMdd", out var date))
                {
                    throw new InvalidOperationException($"Could not parse line {line} as int|date");
                }
                else
                {
                    list.Add(new HoursData(hour, date));
                }
            }

            return list;
        }

        private string Serialise(List<HoursData> data)
        {
            if (data is null || data.Count == 0) return string.Empty;

            var sb = new StringBuilder();
            foreach (var d in data)
            {
                sb.AppendLine($"{d.Hour:F2}|{d.Date:yyyyMMdd}");
            }

            return sb.ToString();
        }
    }
}
