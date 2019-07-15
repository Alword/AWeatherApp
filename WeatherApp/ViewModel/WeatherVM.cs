using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            set
            {
                query = value;
                GetCities();
                OnPropertyChanged();
            }
        }

        public ObservableCollection<City> Cities { get; set; }

        public WeatherVM()
        {
            Weather = new AccuWeather();
            Cities = new ObservableCollection<City>();
        }

        private async void GetCities()
        {
            Cities.Clear();
            List<City> cities = await WeatherApi.GetAutoComplete(Query);
            foreach (City city in cities)
            {
                Cities.Add(city);
            }
        }
    }
}
