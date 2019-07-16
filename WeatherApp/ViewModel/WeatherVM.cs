using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApp.Abstraction;
using WeatherApp.Model;
using WeatherApp.ViewModel.Commands;

namespace WeatherApp.ViewModel
{
    public class WeatherVM : PropertyChangedBase
    {
        private City selectedCity;

        public City SelectedCity
        {
            get { return selectedCity; }
            set { selectedCity = value; GetWeather(); }
        }


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
        public ObservableCollection<DailyForecast> DailyForecasts { get; set; }

        public ICommand RefreshCommand { get; set; }
        public WeatherVM()
        {
            Weather = new AccuWeather();
            Cities = new ObservableCollection<City>();
            SelectedCity = new City();
            DailyForecasts = new ObservableCollection<DailyForecast>();
            RefreshCommand = new RefreshCommand(this);
        }

        private async void GetCities()
        {
            Cities.Clear();
            List<City> cities = await WeatherApi.GetAutoComplete(Query);

            if (cities is null) return;
            foreach (City city in cities)
            {
                Cities.Add(city);
            }
        }

        public async void GetWeather()
        {
            if (selectedCity.Equals(null) || string.IsNullOrEmpty(selectedCity.Key)) return;
            var weather = await WeatherApi.GetWeatherInformation(selectedCity.Key);
            DailyForecasts.Clear();
            foreach (DailyForecast forecast in weather.DailyForecasts)
            {
                DailyForecasts.Add(forecast);
            }
        }
    }
}
