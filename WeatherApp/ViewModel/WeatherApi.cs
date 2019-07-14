using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    public class WeatherApi
    {
        public const string APIKey = "akXFSafLKccRGAbb6aBPugoS6FEvI9Vb";
        public const string DefaultLocation = "294021";
        public const string BaseURL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}?apikey={1}&language=ru-ru&metric=true";

        public static async Task<AccuWeather> GetWeatherInformation(string cityKey = DefaultLocation)
        {
            AccuWeather result = new AccuWeather();

            string url = string.Format(BaseURL, cityKey, APIKey);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responce = await client.GetAsync(url);
                string json = await responce.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<AccuWeather>(json);
            }
            return result;
        }
    }
}
