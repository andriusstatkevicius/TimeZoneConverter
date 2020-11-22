using System.Linq;
using System.Threading.Tasks;
using TimeZoneConverter.Tests.Data;
using TimeZoneConvertUtilities;
using TimeZoneConvertUtilities.Models;
using Xunit;

namespace TimeZoneConverter.Tests
{
    public class DataPopulatorShould
    {
        [Theory]
        [ClassData(typeof(IanaToWindowsZonesData))]
        public async Task ReturnCorrectWindowsTimeZonesAsync(string ianaTimeZone, string expectedWindowsTimeZone)
        {
            DataPopulator dataPopulator = new DataPopulator();

            if (!dataPopulator.IsPopulated())
                await dataPopulator.EnsureDataPopulationAsync();

            Assert.Equal(dataPopulator.IanaToWindows[ianaTimeZone], expectedWindowsTimeZone);
        }

        [Fact]
        public async Task EnsureDataIsPopulatedAsync()
        {
            DataPopulator dataPopulator = new DataPopulator();

            await dataPopulator.EnsureDataPopulationAsync();

            Assert.True(dataPopulator.IsPopulated());
        }

        [Theory]
        [ClassData(typeof(WindowsTimeZoneEntryData))]
        public async Task ReturnCorrectIanaTimeZonesAsync(WindowsTimeZoneEntry testInput)
        {
            DataPopulator dataPopulator = new DataPopulator();

            if (!dataPopulator.IsPopulated())
                await dataPopulator.EnsureDataPopulationAsync();

            bool containsSameNumberOfIanaTimeZones = dataPopulator.WindowsToIana[testInput.WindowsTimeZoneId].Count() == testInput.IANATimeZones.Count();
            bool containsSameIanaTimeZones = dataPopulator.WindowsToIana[testInput.WindowsTimeZoneId].All(populatorOutput => testInput.IANATimeZones.Contains(populatorOutput));
            Assert.True(containsSameIanaTimeZones && containsSameIanaTimeZones);
        }
    }
}
