using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Utilities;

namespace TimeZoneConvertUtilities
{
    public class DataScraper
    {
        private readonly string _url = "https://techsupport.osisoft.com/Documentation/PI-Web-API/help/topics/timezones/iana.html";

        public async Task<List<string[]>> FetchDataFromWebAsync()
        {
            HttpClient client = new HttpClient();
            var requestResult = await client.GetAsync(_url);
            var responseString = await requestResult.Content.ReadAsStringAsync();
            var table = Regexes.Table.Matches(responseString).TryGetString();
            var lineEntries = Regexes.Entries.Matches(table).TryGetArray();

            return lineEntries;
        }
    }
}