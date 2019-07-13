﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    public class Forecast
    {
        public Headline Headline { get; set; }
        public IList<DailyForecast> DailyForecasts { get; set; }
    }
}
