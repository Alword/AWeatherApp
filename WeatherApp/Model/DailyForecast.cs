using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Abstraction;

namespace WeatherApp.Model
{
    public class DailyForecast : ProperyChangedBase
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; OnPropertyChanged(); }
        }

        private int epochDate;

        public int EpochDate
        {
            get { return epochDate; }
            set { epochDate = value; OnPropertyChanged(); }
        }

        private Temperature temperature;

        public Temperature Temperature
        {
            get { return temperature; }
            set { temperature = value; OnPropertyChanged(); }
        }

        private TimeOfDay day;

        public TimeOfDay Day
        {
            get { return day; }
            set { day = value; OnPropertyChanged(); }
        }

        private TimeOfDay night;

        public TimeOfDay Night
        {
            get { return night; }
            set { night = value; OnPropertyChanged(); }
        }

    }
}
