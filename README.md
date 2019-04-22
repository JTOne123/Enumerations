# Enumerations
Enumerable (through linq) types that will make the everyday easier.

## CountryType
A complete set of all 249 countries as enumerable types. With ISO 3166 with alpha 2 and 3 codes, Sovereignty and Internet CcTld.

With properties of:
```
        public string CountryName { get; } // "Denmark"
        public string OfficialStateName { get; } // "The Kingdom of Denmark"
        public string Sovereignty { get; } // "UN member state"
        public string Alpha2Code { get; } // "DK"
        public string Alpha3Code { get; } // "DNK"
        public int CountryCode { get; } // 208
        public string SubdivisionCode { get; } // ISO 3166-2:DK
        public string InternetCcTld { get; } // .dk
```
So you can get Denmark alpha 2 code by doing this:
```
var code = CountryType.Denmark.Alpha2Code
```
or get all UN state members by doing this:
```
var members = CountryType.GetAll().Where( ct => ct.Sovereignty == "UN member state" );
```

Properties that are missing;
 1. Url for official flag.
 2. Geographical location.
 3. (your suggesion here)
