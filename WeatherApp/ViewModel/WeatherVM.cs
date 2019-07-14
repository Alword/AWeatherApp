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
        public AccuWeather Weather { get; set; }

        private string query;

        public string Query
        {
            get { return query; }
            set { query = value; OnPropertyChanged(); }
        }



        public WeatherVM()
        {
            Weather = new AccuWeather();
        }
    }
}
