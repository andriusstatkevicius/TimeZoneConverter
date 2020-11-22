using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TimeZoneConvertUtilities.Models;

namespace TimeZoneConvertUtilities
{
    public class DataPopulator
    {
        private readonly DataRepository _dataRepository;
        private readonly DataScraper _dataScraper;
        public List<IanaTimeZoneEntry> DataEntries { get; private set; } = new List<IanaTimeZoneEntry>();
        public Dictionary<string, string> IanaToWindows { get; private set; } = new Dictionary<string, string>();
        public Dictionary<string, List<string>> WindowsToIana { get; private set; } = new Dictionary<string, List<string>>();

        public DataPopulator()
        {
            _dataRepository = new DataRepository();
            _dataScraper = new DataScraper();
        }

        public async Task EnsureDataPopulationAsync()
        {
            try
            {
                if (IsPopulated())
                    return;

                DataEntries = _dataRepository.GetDataEntries();

                // If there is no data in the database, scrape it from the website and insert into the DB
                if (!DataEntries.Any())
                {
                    var result = await _dataScraper.FetchDataFromWebAsync();
                    result.ForEach(resultEntry => DataEntries.Add(new IanaTimeZoneEntry { IANATimeZoneID = resultEntry[0], WinTimeZoneID = resultEntry[1] }));
                    _dataRepository.InsertEntries(DataEntries);
                }

                if (DataEntries.Any())
                    PopulateDictionaries();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Failed to populate data due to {e}");
            }
        }

        public bool IsPopulated() => DataEntries.Any() && IanaToWindows.Any() && WindowsToIana.Any();

        private void PopulateDictionaries()
        {
            DataEntries.ForEach(entry => IanaToWindows[entry.IANATimeZoneID] = entry.WinTimeZoneID);

            foreach (var entry in DataEntries)
            {
                if (!WindowsToIana.ContainsKey(entry.WinTimeZoneID))
                {
                    WindowsToIana[entry.WinTimeZoneID] = new List<string> { entry.IANATimeZoneID };
                }
                else
                {
                    WindowsToIana[entry.WinTimeZoneID].Add(entry.IANATimeZoneID);
                }
            }
        }
    }
}
