using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Abstraction;

namespace WeatherApp.Model
{
    public class AccuWeather
    {
        public List<DailyForecast> DailyForecasts { get; set; }

        public AccuWeather()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                DailyForecasts = new List<DailyForecast>();
                for (int i = 0; i < 3; i++)
                {
                    DailyForecast dailyForecast = new DailyForecast
                    {
                        Date = DateTime.Now.AddDays(-i),
                        Temperature = new Temperature
                        {
                            Maximum = new Range
                            {
                                Value = 21 + i
                            },
                            Minimum = new Range
                            {
                                Value = 5 - i
                            }
                        }
                    };
                    DailyForecasts.Add(dailyForecast);
                }
            }
        }
    }
}
