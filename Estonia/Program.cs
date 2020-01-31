using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Estonia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://restcountries.eu/rest/v2/name/eesti";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using var responseStream = new StreamReader(webStream);
            var response = responseStream.ReadToEnd();

            //Since starting point of JSON is [0]: which is easily shown in mozilla under JSON table, the JSON parsin must be done directly to list
            List<CountryData.Root> countryDetails = JsonConvert.DeserializeObject<List<CountryData.Root>>(response);

            Console.WriteLine($"Country name:       {countryDetails[0].Name}");
            Console.WriteLine($"Country cioc:       {countryDetails[0].Cioc}");
            Console.WriteLine($"Country domain:     {countryDetails[0].TopLevelDomain[0]}");
            Console.WriteLine($"Country capital:    {countryDetails[0].Capital}");
            Console.WriteLine($"Country region:     {countryDetails[0].Region}");
            Console.WriteLine($"Country population: {countryDetails[0].Population}");
            Console.WriteLine($"Country language:   {countryDetails[0].Languages[0].Name}");
            Console.WriteLine($"Country borders:    {countryDetails[0].Borders[0]}");
            Console.WriteLine($"Country borders:    {countryDetails[0].Borders[1]}");


        }

    }
}
