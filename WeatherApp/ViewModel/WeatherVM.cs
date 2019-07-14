using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Abstraction;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    public class WeatherVM : PropertyChangedBase
    {
        private AccuWeather weather;

        public AccuWeather Weather
        {
            get { return weather; }
            set { weather = value; OnPropertyChanged(); }
        }

        public WeatherVM()
        {
            Weather = new AccuWeather();
        }
    }
}
