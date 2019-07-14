using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    public class WeatherApi
    {
        public const string APIKey = "akXFSafLKccRGAbb6aBPugoS6FEvI9Vb";
        public const string DefaultLocation = "294021";
        public const string BaseURL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}?apikey={1}&language=ru-ru&metric=true";
        public const string BaseURLAutocomplete = "http://dataservice.accuweather.com/locations/v1/cities/autocomplete?apikey={0}&q={1}&language=ru-ru";

        public static async Task<AccuWeather> GetWeatherInformation(string cityKey = DefaultLocation)
        {
            string url = string.Format(BaseURL, cityKey, APIKey);

            AccuWeather result = await GetJsonRequest<AccuWeather>(url);

            return result;
        }

        public static async Task<List<City>> GetAutoComplete(string CityName = "Тула")
        {
            string url = string.Format(BaseURLAutocomplete, APIKey, CityName);

            List<City> result = await GetJsonRequest<List<City>>(url);
            
            return result;
        }

        private async static Task<T> GetJsonRequest<T>(string url)
        {
            T result;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responce = await client.GetAsync(url);
                string json = await responce.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<T>(json);
            }
            return result;
        }
    }
}
