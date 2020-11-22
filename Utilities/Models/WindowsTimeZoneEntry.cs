namespace TimeZoneConvertUtilities.Models
{
    public class WindowsTimeZoneEntry
    {
        public string WindowsTimeZoneId;
        public string[] IANATimeZones;

        public WindowsTimeZoneEntry(string windowsTimeZoneId, string[] ianaTimeZones)
        {
            WindowsTimeZoneId = windowsTimeZoneId;
            IANATimeZones = ianaTimeZones;
        }
    }
}
