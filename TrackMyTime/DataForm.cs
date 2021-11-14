using TrackMyTime.Services;
using TrackMyTime.Tools;

namespace TrackMyTime
{
    public partial class DataForm : Form
    {
        private readonly IDataLoader _dataLoader;
        private readonly IAccruedHoursCalculator _accruedHoursCalculator;
        private List<HoursData> _data;
        private bool _errorState;

        public DataForm(IDataLoader dataLoader, IAccruedHoursCalculator accruedHoursCalculator)
        {
            _dataLoader = dataLoader;
            _accruedHoursCalculator = accruedHoursCalculator;
            InitializeComponent();
            ResetErrorMessage();

            LoadSavedData(dataLoader);
        }

        private void LoadSavedData(IDataLoader dataLoader)
        {
            try
            {
                _data = dataLoader.GetData();
            }
            catch (Exception ex)
            {
                ShowError($"There were issues when parsing the file. Some data was corrupt.\n\n{ex.Message}");
                submitButton.Enabled = false;
                _errorState = true;
            }

            ShowAccruedHours();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ResetErrorMessage();
            var value = hoursCompletedInput.Text;
            var date = DateOnly.FromDateTime(dateTimePicker.Value);

            if (!ValidateDate(date))
            {
                ShowError("A value was already added for this week.");
                return;
            }

            var strings = value.Split(":");
            if (strings.Length > 1 && int.TryParse(strings[0], out var hours) && int.TryParse(strings[1], out var minutes))
            {
                _data.Add(new HoursData(hours + TimeSpan.FromMinutes(minutes).TotalHours, date));
            }
            else if (double.TryParse(value, out var hour))
            {
                _data.Add(new HoursData(hour, date));
            }
            else
            {
                ShowError("Please enter a decimal value, or in format hh:mm.");
                hoursCompletedInput.Text = string.Empty;
                return;
            }

            ShowAccruedHours();
        }

        private void ShowAccruedHours()
        {
            hoursAccruedValue.Text = _accruedHoursCalculator.Calculate(_data).ToString();

            lastUpdatedBox.Text = Week.GetWeeksSinceDate(_accruedHoursCalculator.GetLastUpdated(_data));
        }

        private void ShowError(string message)
        {
            ErrorLabel.Text = message;
        }

        private void ResetErrorMessage()
        {
            ErrorLabel.Text = string.Empty;
        }

        private bool ValidateDate(DateOnly date)
        {
            return !_data.Any(data => Week.GetForDate(date).Contains(data.Date));
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!_errorState)
            {
                ResetErrorMessage();
            }
        }

        private void hoursCompletedInput_Enter(object sender, EventArgs e)
        {
            if (!_errorState)
            {
                ResetErrorMessage();
            }
        }

        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_errorState)
            {
                _dataLoader.Save(_data);
            }
        }
    }
}