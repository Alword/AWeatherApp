using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Abstraction;

namespace WeatherApp.Model
{
    public class AccuWeather : ProperyChangedBase
    {
        private List<DailyForecast> dailyForecasts = null;
        public List<DailyForecast> DailyForecasts
        {
            get => dailyForecasts;
            set
            {
                dailyForecasts = value;
                OnPropertyChanged();
            }
        }
    }
}
