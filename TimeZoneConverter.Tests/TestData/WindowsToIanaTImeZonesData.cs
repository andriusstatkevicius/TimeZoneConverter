﻿using System.Collections;
using System.Collections.Generic;
using TimeZoneConvertUtilities.Models;

namespace TimeZoneConverter.Tests.Data
{
    public class WindowsTimeZoneEntryData : IEnumerable<object[]>
    {
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new WindowsTimeZoneEntry("Afghanistan Standard Time", new string[] { "Asia/Kabul" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Alaskan Standard Time", new string[] { "America/Anchorage", "America/Juneau", "America/Metlakatla", "America/Nome", "America/Sitka", "America/Yakutat", "US/Alaska" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Aleutian Standard Time", new string[] { "America/Adak", "America/Atka", "US/Aleutian" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Altai Standard Time", new string[] { "Asia/Barnaul" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Arab Standard Time", new string[] { "Asia/Aden", "Asia/Bahrain", "Asia/Kuwait", "Asia/Qatar", "Asia/Riyadh" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Arabian Standard Time", new string[] { "Asia/Dubai", "Asia/Muscat", "Etc/GMT-4" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Arabic Standard Time", new string[] { "Asia/Baghdad" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Argentina Standard Time", new string[] { "America/Argentina/Buenos_Aires", "America/Argentina/Catamarca", "America/Argentina/ComodRivadavia", "America/Argentina/Cordoba", "America/Argentina/Jujuy", "America/Argentina/La_Rioja", "America/Argentina/Mendoza", "America/Argentina/Rio_Gallegos", "America/Argentina/Salta", "America/Argentina/San_Juan", "America/Argentina/San_Luis", "America/Argentina/Tucuman", "America/Argentina/Ushuaia", "America/Buenos_Aires", "America/Catamarca", "America/Cordoba", "America/Jujuy", "America/Mendoza", "America/Rosario" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Astrakhan Standard Time", new string[] { "Europe/Astrakhan", "Europe/Ulyanovsk" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Atlantic Standard Time", new string[] { "America/Glace_Bay", "America/Goose_Bay", "America/Halifax", "America/Moncton", "America/Thule", "Atlantic/Bermuda", "Canada/Atlantic" }) };
            yield return new object[] { new WindowsTimeZoneEntry("AUS Central Standard Time", new string[] { "Australia/Darwin", "Australia/North" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Aus Central W. Standard Time", new string[] { "Australia/Eucla" }) };
            yield return new object[] { new WindowsTimeZoneEntry("AUS Eastern Standard Time", new string[] { "Australia/ACT", "Australia/Canberra", "Australia/Melbourne", "Australia/NSW", "Australia/Sydney", "Australia/Victoria" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Azerbaijan Standard Time", new string[] { "Asia/Baku" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Azores Standard Time", new string[] { "America/Scoresbysund", "Atlantic/Azores" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Bahia Standard Time", new string[] { "America/Bahia" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Bangladesh Standard Time", new string[] { "Asia/Dacca", "Asia/Dhaka", "Asia/Thimbu", "Asia/Thimphu" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Belarus Standard Time", new string[] { "Europe/Minsk" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Bougainville Standard Time", new string[] { "Pacific/Bougainville" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Canada Central Standard Time", new string[] { "America/Regina", "America/Swift_Current", "Canada/East-Saskatchewan", "Canada/Saskatchewan" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Cape Verde Standard Time", new string[] { "Atlantic/Cape_Verde", "Etc/GMT+1" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Caucasus Standard Time", new string[] { "Asia/Yerevan" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Cen. Australia Standard Time", new string[] { "Australia/Adelaide", "Australia/Broken_Hill", "Australia/South", "Australia/Yancowinna" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Central America Standard Time", new string[] { "America/Belize", "America/Costa_Rica", "America/El_Salvador", "America/Guatemala", "America/Managua", "America/Tegucigalpa", "Etc/GMT+6", "Pacific/Galapagos" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Central Asia Standard Time", new string[] { "Antarctica/Vostok", "Asia/Almaty", "Asia/Bishkek", "Asia/Kashgar", "Asia/Qyzylorda", "Asia/Urumqi", "Etc/GMT-6", "Indian/Chagos" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Central Brazilian Standard Time", new string[] { "America/Campo_Grande", "America/Cuiaba" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Central Europe Standard Time", new string[] { "Europe/Belgrade", "Europe/Bratislava", "Europe/Budapest", "Europe/Ljubljana", "Europe/Podgorica", "Europe/Prague", "Europe/Tirane" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Central European Standard Time", new string[] { "Europe/Sarajevo", "Europe/Skopje", "Europe/Warsaw", "Europe/Zagreb", "Poland" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Central Pacific Standard Time", new string[] { "Antarctica/Macquarie", "Etc/GMT-11", "Pacific/Efate", "Pacific/Guadalcanal", "Pacific/Kosrae", "Pacific/Noumea", "Pacific/Pohnpei", "Pacific/Ponape" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Central Standard Time (Mexico)", new string[] { "America/Bahia_Banderas", "America/Merida", "America/Mexico_City", "America/Monterrey", "Mexico/General" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Central Standard Time", new string[] { "America/Chicago", "America/Indiana/Knox", "America/Indiana/Tell_City", "America/Knox_IN", "America/Matamoros", "America/Menominee", "America/North_Dakota/Beulah", "America/North_Dakota/Center", "America/North_Dakota/New_Salem", "America/Rainy_River", "America/Rankin_Inlet", "America/Resolute", "America/Winnipeg", "Canada/Central", "CST6CDT", "US/Central", "US/Indiana-Starke" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Chatham Islands Standard Time", new string[] { "NZ-CHAT", "Pacific/Chatham" }) };
            yield return new object[] { new WindowsTimeZoneEntry("China Standard Time", new string[] { "Asia/Chongqing", "Asia/Chungking", "Asia/Harbin", "Asia/Hong_Kong", "Asia/Macao", "Asia/Macau", "Asia/Shanghai", "Hongkong", "PRC" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Cuba Standard Time", new string[] { "America/Havana", "Cuba" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Dateline Standard Time", new string[] { "Etc/GMT+12" }) };
            yield return new object[] { new WindowsTimeZoneEntry("E. Africa Standard Time", new string[] { "Africa/Addis_Ababa", "Africa/Asmara", "Africa/Asmera", "Africa/Dar_es_Salaam", "Africa/Djibouti", "Africa/Juba", "Africa/Kampala", "Africa/Khartoum", "Africa/Mogadishu", "Africa/Nairobi", "Antarctica/Syowa", "Etc/GMT-3", "Indian/Antananarivo", "Indian/Comoro", "Indian/Mayotte" }) };
            yield return new object[] { new WindowsTimeZoneEntry("E. Australia Standard Time", new string[] { "Australia/Brisbane", "Australia/Lindeman", "Australia/Queensland" }) };
            yield return new object[] { new WindowsTimeZoneEntry("E. Europe Standard Time", new string[] { "Europe/Chisinau", "Europe/Tiraspol" }) };
            yield return new object[] { new WindowsTimeZoneEntry("E. South America Standard Time", new string[] { "America/Sao_Paulo", "Brazil/East" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Easter Island Standard Time", new string[] { "Chile/EasterIsland", "Pacific/Easter" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Eastern Standard Time (Mexico)", new string[] { "America/Cancun" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Eastern Standard Time", new string[] { "America/Detroit", "America/Indiana/Petersburg", "America/Indiana/Vincennes", "America/Indiana/Winamac", "America/Iqaluit", "America/Kentucky/Louisville", "America/Kentucky/Monticello", "America/Louisville", "America/Montreal", "America/Nassau", "America/New_York", "America/Nipigon", "America/Pangnirtung", "America/Thunder_Bay", "America/Toronto", "Canada/Eastern", "EST5EDT", "US/Eastern", "US/Michigan" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Egypt Standard Time", new string[] { "Africa/Cairo", "Egypt" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Ekaterinburg Standard Time", new string[] { "Asia/Yekaterinburg" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Fiji Standard Time", new string[] { "Pacific/Fiji" }) };
            yield return new object[] { new WindowsTimeZoneEntry("FLE Standard Time", new string[] { "Europe/Helsinki", "Europe/Kiev", "Europe/Mariehamn", "Europe/Riga", "Europe/Sofia", "Europe/Tallinn", "Europe/Uzhgorod", "Europe/Vilnius", "Europe/Zaporozhye" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Georgian Standard Time", new string[] { "Asia/Tbilisi" }) };
            yield return new object[] { new WindowsTimeZoneEntry("GMT Standard Time", new string[] { "Atlantic/Canary", "Atlantic/Faeroe", "Atlantic/Faroe", "Atlantic/Madeira", "Eire", "Europe/Belfast", "Europe/Dublin", "Europe/Guernsey", "Europe/Isle_of_Man", "Europe/Jersey", "Europe/Lisbon", "Europe/London", "GB", "GB-Eire", "Portugal" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Greenland Standard Time", new string[] { "America/Godthab" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Greenwich Standard Time", new string[] { "Africa/Abidjan", "Africa/Accra", "Africa/Bamako", "Africa/Banjul", "Africa/Bissau", "Africa/Conakry", "Africa/Dakar", "Africa/Freetown", "Africa/Lome", "Africa/Monrovia", "Africa/Nouakchott", "Africa/Ouagadougou", "Africa/Sao_Tome", "Africa/Timbuktu", "Atlantic/Reykjavik", "Atlantic/St_Helena", "Iceland" }) };
            yield return new object[] { new WindowsTimeZoneEntry("GTB Standard Time", new string[] { "Asia/Nicosia", "Europe/Athens", "Europe/Bucharest", "Europe/Nicosia" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Haiti Standard Time", new string[] { "America/Port-au-Prince" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Hawaiian Standard Time", new string[] { "Etc/GMT+10", "HST", "Pacific/Honolulu", "Pacific/Johnston", "Pacific/Rarotonga", "Pacific/Tahiti", "US/Hawaii" }) };
            yield return new object[] { new WindowsTimeZoneEntry("India Standard Time", new string[] { "Asia/Calcutta", "Asia/Kolkata" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Iran Standard Time", new string[] { "Asia/Tehran", "Iran" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Israel Standard Time", new string[] { "Asia/Jerusalem", "Asia/Tel_Aviv", "Israel" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Jordan Standard Time", new string[] { "Asia/Amman" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Kaliningrad Standard Time", new string[] { "Europe/Kaliningrad" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Korea Standard Time", new string[] { "Asia/Seoul", "ROK" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Libya Standard Time", new string[] { "Africa/Tripoli", "Libya" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Line Islands Standard Time", new string[] { "Etc/GMT-14", "Pacific/Kiritimati" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Lord Howe Standard Time", new string[] { "Australia/LHI", "Australia/Lord_Howe" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Magadan Standard Time", new string[] { "Asia/Magadan" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Marquesas Standard Time", new string[] { "Pacific/Marquesas" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Mauritius Standard Time", new string[] { "Indian/Mahe", "Indian/Mauritius", "Indian/Reunion" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Middle East Standard Time", new string[] { "Asia/Beirut" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Montevideo Standard Time", new string[] { "America/Montevideo" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Morocco Standard Time", new string[] { "Africa/Casablanca", "Africa/El_Aaiun" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Mountain Standard Time (Mexico)", new string[] { "America/Chihuahua", "America/Mazatlan", "Mexico/BajaSur" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Mountain Standard Time", new string[] { "America/Boise", "America/Cambridge_Bay", "America/Denver", "America/Edmonton", "America/Inuvik", "America/Ojinaga", "America/Shiprock", "America/Yellowknife", "Canada/Mountain", "MST7MDT", "Navajo", "US/Mountain" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Myanmar Standard Time", new string[] { "Asia/Rangoon", "Indian/Cocos" }) };
            yield return new object[] { new WindowsTimeZoneEntry("N. Central Asia Standard Time", new string[] { "Asia/Novosibirsk", "Asia/Omsk" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Namibia Standard Time", new string[] { "Africa/Windhoek" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Nepal Standard Time", new string[] { "Asia/Kathmandu", "Asia/Katmandu" }) };
            yield return new object[] { new WindowsTimeZoneEntry("New Zealand Standard Time", new string[] { "Antarctica/McMurdo", "Antarctica/South_Pole", "NZ", "Pacific/Auckland" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Newfoundland Standard Time", new string[] { "America/St_Johns", "Canada/Newfoundland" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Norfolk Standard Time", new string[] { "Pacific/Norfolk" }) };
            yield return new object[] { new WindowsTimeZoneEntry("North Asia East Standard Time", new string[] { "Asia/Irkutsk" }) };
            yield return new object[] { new WindowsTimeZoneEntry("North Asia Standard Time", new string[] { "Asia/Krasnoyarsk", "Asia/Novokuznetsk" }) };
            yield return new object[] { new WindowsTimeZoneEntry("North Korea Standard Time", new string[] { "Asia/Pyongyang" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Pacific SA Standard Time", new string[] { "America/Santiago", "Antarctica/Palmer", "Chile/Continental" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Pacific Standard Time (Mexico)", new string[] { "America/Ensenada", "America/Santa_Isabel", "America/Tijuana", "Mexico/BajaNorte" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Pacific Standard Time", new string[] { "America/Dawson", "America/Los_Angeles", "America/Vancouver", "America/Whitehorse", "Canada/Pacific", "Canada/Yukon", "PST8PDT", "US/Pacific", "US/Pacific-New" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Pakistan Standard Time", new string[] { "Asia/Karachi" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Paraguay Standard Time", new string[] { "America/Asuncion" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Romance Standard Time", new string[] { "Africa/Ceuta", "Europe/Brussels", "Europe/Copenhagen", "Europe/Madrid", "Europe/Paris" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Russia Time Zone 10", new string[] { "Asia/Srednekolymsk" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Russia Time Zone 11", new string[] { "Asia/Anadyr", "Asia/Kamchatka" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Russia Time Zone 3", new string[] { "Europe/Samara" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Russian Standard Time", new string[] { "Europe/Kirov", "Europe/Moscow", "Europe/Simferopol", "Europe/Volgograd", "W-SU" }) };
            yield return new object[] { new WindowsTimeZoneEntry("SA Eastern Standard Time", new string[] { "America/Belem", "America/Cayenne", "America/Fortaleza", "America/Maceio", "America/Paramaribo", "America/Recife", "America/Santarem", "Antarctica/Rothera", "Atlantic/Stanley", "Etc/GMT+3" }) };
            yield return new object[] { new WindowsTimeZoneEntry("SA Pacific Standard Time", new string[] { "America/Atikokan", "America/Bogota", "America/Cayman", "America/Coral_Harbour", "America/Eirunepe", "America/Guayaquil", "America/Jamaica", "America/Lima", "America/Panama", "America/Porto_Acre", "America/Rio_Branco", "Brazil/Acre", "EST", "Etc/GMT+5", "Jamaica" }) };
            yield return new object[] { new WindowsTimeZoneEntry("SA Western Standard Time", new string[] { "America/Anguilla", "America/Antigua", "America/Aruba", "America/Barbados", "America/Blanc-Sablon", "America/Boa_Vista", "America/Curacao", "America/Dominica", "America/Grenada", "America/Guadeloupe", "America/Guyana", "America/Kralendijk", "America/La_Paz", "America/Lower_Princes", "America/Manaus", "America/Marigot", "America/Martinique", "America/Montserrat", "America/Port_of_Spain", "America/Porto_Velho", "America/Puerto_Rico", "America/Santo_Domingo", "America/St_Barthelemy", "America/St_Kitts", "America/St_Lucia", "America/St_Thomas", "America/St_Vincent", "America/Tortola", "America/Virgin", "Brazil/West", "Etc/GMT+4" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Saint Pierre Standard Time", new string[] { "America/Miquelon" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Sakhalin Standard Time", new string[] { "Asia/Sakhalin" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Samoa Standard Time", new string[] { "Pacific/Apia" }) };
            yield return new object[] { new WindowsTimeZoneEntry("SE Asia Standard Time", new string[] { "Antarctica/Davis", "Asia/Bangkok", "Asia/Ho_Chi_Minh", "Asia/Jakarta", "Asia/Phnom_Penh", "Asia/Pontianak", "Asia/Saigon", "Asia/Vientiane", "Etc/GMT-7", "Indian/Christmas" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Singapore Standard Time", new string[] { "Asia/Brunei", "Asia/Kuala_Lumpur", "Asia/Kuching", "Asia/Makassar", "Asia/Manila", "Asia/Singapore", "Asia/Ujung_Pandang", "Etc/GMT-8", "Singapore" }) };
            yield return new object[] { new WindowsTimeZoneEntry("South Africa Standard Time", new string[] { "Africa/Blantyre", "Africa/Bujumbura", "Africa/Gaborone", "Africa/Harare", "Africa/Johannesburg", "Africa/Kigali", "Africa/Lubumbashi", "Africa/Lusaka", "Africa/Maputo", "Africa/Maseru", "Africa/Mbabane", "Etc/GMT-2" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Sri Lanka Standard Time", new string[] { "Asia/Colombo" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Syria Standard Time", new string[] { "Asia/Damascus" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Taipei Standard Time", new string[] { "Asia/Taipei", "ROC" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Tasmania Standard Time", new string[] { "Australia/Currie", "Australia/Hobart", "Australia/Tasmania" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Tocantins Standard Time", new string[] { "America/Araguaina" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Tokyo Standard Time", new string[] { "Asia/Dili", "Asia/Jayapura", "Asia/Tokyo", "Etc/GMT-9", "Japan", "Pacific/Palau" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Tomsk Standard Time", new string[] { "Asia/Tomsk" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Tonga Standard Time", new string[] { "Etc/GMT-13", "Pacific/Enderbury", "Pacific/Fakaofo", "Pacific/Tongatapu" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Transbaikal Standard Time", new string[] { "Asia/Chita" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Turkey Standard Time", new string[] { "Asia/Istanbul", "Europe/Istanbul", "Turkey" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Turks And Caicos Standard Time", new string[] { "America/Grand_Turk" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Ulaanbaatar Standard Time", new string[] { "Asia/Choibalsan", "Asia/Ulaanbaatar", "Asia/Ulan_Bator" }) };
            yield return new object[] { new WindowsTimeZoneEntry("US Eastern Standard Time", new string[] { "America/Fort_Wayne", "America/Indiana/Indianapolis", "America/Indiana/Marengo", "America/Indiana/Vevay", "America/Indianapolis", "US/East-Indiana" }) };
            yield return new object[] { new WindowsTimeZoneEntry("US Mountain Standard Time", new string[] { "America/Creston", "America/Dawson_Creek", "America/Fort_Nelson", "America/Hermosillo", "America/Phoenix", "Etc/GMT+7", "MST", "US/Arizona" }) };
            yield return new object[] { new WindowsTimeZoneEntry("UTC", new string[] { "America/Danmarkshavn", "Etc/GMT", "Etc/GMT+0", "Etc/GMT0", "Etc/GMT-0", "Etc/Greenwich", "Etc/UCT", "Etc/Universal", "Etc/UTC", "Etc/Zulu", "GMT", "GMT+0", "GMT0", "GMT-0", "Greenwich", "UCT", "Universal", "UTC", "Zulu" }) };
            yield return new object[] { new WindowsTimeZoneEntry("UTC+12", new string[] { "Etc/GMT-12", "Kwajalein", "Pacific/Funafuti", "Pacific/Kwajalein", "Pacific/Majuro", "Pacific/Nauru", "Pacific/Tarawa", "Pacific/Wake", "Pacific/Wallis" }) };
            yield return new object[] { new WindowsTimeZoneEntry("UTC-02", new string[] { "America/Noronha", "Atlantic/South_Georgia", "Brazil/DeNoronha", "Etc/GMT+2" }) };
            yield return new object[] { new WindowsTimeZoneEntry("UTC-08", new string[] { "Etc/GMT+8", "Pacific/Pitcairn" }) };
            yield return new object[] { new WindowsTimeZoneEntry("UTC-09", new string[] { "Etc/GMT+9", "Pacific/Gambier" }) };
            yield return new object[] { new WindowsTimeZoneEntry("UTC-11", new string[] { "Etc/GMT+11", "Pacific/Midway", "Pacific/Niue", "Pacific/Pago_Pago", "Pacific/Samoa", "US/Samoa" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Venezuela Standard Time", new string[] { "America/Caracas" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Vladivostok Standard Time", new string[] { "Asia/Ust-Nera", "Asia/Vladivostok" }) };
            yield return new object[] { new WindowsTimeZoneEntry("W. Australia Standard Time", new string[] { "Antarctica/Casey", "Australia/Perth", "Australia/West" }) };
            yield return new object[] { new WindowsTimeZoneEntry("W. Central Africa Standard Time", new string[] { "Africa/Algiers", "Africa/Bangui", "Africa/Brazzaville", "Africa/Douala", "Africa/Kinshasa", "Africa/Lagos", "Africa/Libreville", "Africa/Luanda", "Africa/Malabo", "Africa/Ndjamena", "Africa/Niamey", "Africa/Porto-Novo", "Africa/Tunis", "Etc/GMT-1" }) };
            yield return new object[] { new WindowsTimeZoneEntry("W. Europe Standard Time", new string[] { "Arctic/Longyearbyen", "Atlantic/Jan_Mayen", "Europe/Amsterdam", "Europe/Andorra", "Europe/Berlin", "Europe/Busingen", "Europe/Gibraltar", "Europe/Luxembourg", "Europe/Malta", "Europe/Monaco", "Europe/Oslo", "Europe/Rome", "Europe/San_Marino", "Europe/Stockholm", "Europe/Vaduz", "Europe/Vatican", "Europe/Vienna", "Europe/Zurich" }) };
            yield return new object[] { new WindowsTimeZoneEntry("W. Mongolia Standard Time", new string[] { "Asia/Hovd" }) };
            yield return new object[] { new WindowsTimeZoneEntry("West Asia Standard Time", new string[] { "Antarctica/Mawson", "Asia/Aqtau", "Asia/Aqtobe", "Asia/Ashgabat", "Asia/Ashkhabad", "Asia/Dushanbe", "Asia/Oral", "Asia/Samarkand", "Asia/Tashkent", "Etc/GMT-5", "Indian/Kerguelen", "Indian/Maldives" }) };
            yield return new object[] { new WindowsTimeZoneEntry("West Bank Standard Time", new string[] { "Asia/Gaza", "Asia/Hebron" }) };
            yield return new object[] { new WindowsTimeZoneEntry("West Pacific Standard Time", new string[] { "Antarctica/DumontDUrville", "Etc/GMT-10", "Pacific/Chuuk", "Pacific/Guam", "Pacific/Port_Moresby", "Pacific/Saipan", "Pacific/Truk", "Pacific/Yap" }) };
            yield return new object[] { new WindowsTimeZoneEntry("Yakutsk Standard Time", new string[] { "Asia/Khandyga", "Asia/Yakutsk" }) };
        }

    }
}