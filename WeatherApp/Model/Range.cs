using WeatherApp.Abstraction;

namespace WeatherApp.Model
{
    public class Range : PropertyChangedBase
    {
        private double value;

        public double Value
        {
            get { return value; }
            set { this.value = value; OnPropertyChanged(); }
        }

        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; OnPropertyChanged(); }
        }

        private int unitType;

        public int UnitType
        {
            get { return unitType; }
            set { unitType = value; OnPropertyChanged(); }
        }
    }
}
