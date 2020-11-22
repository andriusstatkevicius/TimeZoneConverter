using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeZoneConvertUtilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeZoneConverter
{
    public partial class Form1 : Form
    {
        private readonly DataPopulator _dataPopulator;
        private ConversionDirection conversionDirection;

        private enum ConversionDirection { ToWindows, ToIana }

        public Form1()
        {
            InitializeComponent();
            _dataPopulator = new DataPopulator();
        }

        private async void ConversionType_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            await _dataPopulator.EnsureDataPopulationAsync();
            if (!_dataPopulator.IsPopulated())
            {
                MessageBox.Show("An error has occured!");
                return;
            }

            ClearInput();

            conversionDirection = ConversionType.SelectedIndex == 0 ? ConversionDirection.ToWindows : ConversionDirection.ToIana;

            switch (conversionDirection)
            {
                case ConversionDirection.ToWindows:
                    _dataPopulator.DataEntries.OrderBy(x => x.IANATimeZoneID)
                                               .ToList()
                                               .ForEach(entry => comboBox2.Items.Add(entry.IANATimeZoneID));
                    break;
                case ConversionDirection.ToIana:
                    var distinctEntries = _dataPopulator.DataEntries.Select(x => x.WinTimeZoneID)
                                                                    .Distinct()
                                                                     .OrderBy(x => x).ToList();

                    distinctEntries.ForEach(entry => comboBox2.Items.Add(entry));
                    break;
            }
        }

        private void ClearInput()
        {
            if (comboBox2.Items.Count > 0)
                comboBox2.Items.Clear();

            if (!string.IsNullOrEmpty(ConversionResultBox.Text))
                ConversionResultBox.Text = string.Empty;

            comboBox2.Text = "";
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            switch (conversionDirection)
            {
                case ConversionDirection.ToWindows:
                    PopulateFormWithResultToWindowsID();
                    break;
                case ConversionDirection.ToIana:
                    PopulateWithResultTOIana();
                    break;
            }
        }

        private void PopulateWithResultTOIana()
        {
            if (!IsInputValid(out string selectedItem))
            {
                MessageBox.Show("Error: Incorrect input");
                return;
            }

            var conversionResult = _dataPopulator.WindowsToIana[selectedItem].OrderBy(x => x).ToList();
            var sb = new StringBuilder();
            sb.Append("Respective IANA Time Zone Ids:")
              .Append(Environment.NewLine);

            var localTime = GetWindowsSystemTime(selectedItem);

            conversionResult.ForEach(x => sb.Append(x).Append(Environment.NewLine));
            sb.Append(localTime);
            ConversionResultBox.Text = sb.ToString();
            AutoSizeTextBox(ConversionResultBox);
        }

        private bool IsInputValid(out string selectedItem)
        {
            selectedItem = comboBox2.SelectedItem?.ToString();
            if (selectedItem is null)
                return false;

            switch (conversionDirection)
            {
                case ConversionDirection.ToWindows:
                    return _dataPopulator.IanaToWindows.ContainsKey(selectedItem);
                case ConversionDirection.ToIana:
                    return _dataPopulator.WindowsToIana.ContainsKey(selectedItem);
                default:
                    return false;
            }
        }

        private void PopulateFormWithResultToWindowsID()
        {
            if (!IsInputValid(out string selectedItem))
            {
                MessageBox.Show("Error: Incorrect input");
                return;
            }

            var windowsSystemID = _dataPopulator.IanaToWindows[selectedItem];
            var localTime = GetWindowsSystemTime(windowsSystemID);

            var sb = new StringBuilder();
            sb.Append(string.Format("Windows system id: {0}", windowsSystemID))
              .Append(Environment.NewLine)
              .Append(localTime);

            string text = sb.ToString();
            ConversionResultBox.Text = sb.ToString();
            AutoSizeTextBox(ConversionResultBox);
        }

        private void AutoSizeTextBox(System.Windows.Forms.TextBox txt)
        {
            const int x_margin = 0;
            const int y_margin = 2;
            Size size = TextRenderer.MeasureText(txt.Text, txt.Font);
            txt.ClientSize =
                new Size(size.Width + x_margin, size.Height + y_margin);
        }

        private string GetWindowsSystemTime(string windowsSystemID)
        {
            DateTime utcTime = DateTime.UtcNow;
            string result = string.Empty;

            try
            {
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById(windowsSystemID);
                DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, cstZone);
                result = string.Format("The date and time are {0} ({1}).",
                                       cstTime,
                                       cstZone.IsDaylightSavingTime(cstTime) ?
                                               cstZone.DaylightName : cstZone.StandardName);
            }
            catch (TimeZoneNotFoundException)
            {
                Debug.WriteLine("The registry does not define the Central Standard Time zone.");
            }
            catch (InvalidTimeZoneException)
            {
                Debug.WriteLine("Registry data on the Central Standard Time zone has been corrupted.");
            }

            return result;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ConversionResultBox.Text))
                ConversionResultBox.Text = string.Empty;
        }
    }
}
