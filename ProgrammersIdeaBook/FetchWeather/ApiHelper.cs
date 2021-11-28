using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace FetchWeather
{
    public class ApiHelper
    {
        //https://api.weatherapi.com/v1/current.json?key={key}&q={zip}&aqi=no
        public async Task<Weather> GetWeather(string apiKey, string location)
        {
            Weather weather = new Weather();
            string baseUrl = "https://api.weatherapi.com/v1/current.json";

            var queryParams = new Dictionary<string, string>()
            {
                { "key", apiKey },
                { "q", location},
                { "aqi", "no" }
            };
            var requestUri = QueryHelpers.AddQueryString(baseUrl, queryParams);
            
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var response = await client.SendAsync(request);

            if(response.IsSuccessStatusCode)
            {
                var dcjs = new DataContractJsonSerializer(typeof(Weather));
                using var responseStream = await response.Content.ReadAsStreamAsync();
                weather = (Weather)dcjs.ReadObject(responseStream);
            }

            return weather;
        }
    }
}
