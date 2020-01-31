using System;
using System.Collections.Generic;

namespace Estonia
{
    public class CountryData
    {
        public class Currency
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Symbol { get; set; }// Suured tähed getteritel ja setteritel
        }

        public class Language
        {
            public string iso639_1 { get; set; }
            public string iso639_2 { get; set; }
            public string Name { get; set; }
            public string nativeName { get; set; }
        }

        public class Translations
        {
            public string de { get; set; }
            public string es { get; set; }
            public string fr { get; set; }
            public string ja { get; set; }
            public string it { get; set; }
            public string br { get; set; }
            public string pt { get; set; }
            public string nl { get; set; }
            public string hr { get; set; }
            public string fa { get; set; }
        }

        public class RegionalBloc
        {
            public string acronym { get; set; }
            public string name { get; set; }
            public List<object> otherAcronyms { get; set; }
            public List<object> otherNames { get; set; }
        }

        public class Root
        {
            public string Name { get; set; }
            public List<string> TopLevelDomain { get; set; }
            public string alpha2Code { get; set; }
            public string alpha3Code { get; set; }
            public List<string> callingCodes { get; set; }
            public string Capital { get; set; }
            public List<string> altSpellings { get; set; }
            public string Region { get; set; }
            public string subregion { get; set; }
            public int Population { get; set; }
            public List<double> latlng { get; set; }
            public string demonym { get; set; }
            public double area { get; set; }
            public double gini { get; set; }
            public List<string> timezones { get; set; }
            public List<string> Borders { get; set; }
            public string nativeName { get; set; }
            public string numericCode { get; set; }
            public List<Currency> currencies { get; set; }
            public List<Language> Languages { get; set; }
            public Translations Translations { get; set; }
            public string flag { get; set; }
            public List<RegionalBloc> regionalBlocs { get; set; }
            public string Cioc { get; set; }
        }
    }
}
