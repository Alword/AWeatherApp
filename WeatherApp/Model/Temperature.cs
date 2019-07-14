using WeatherApp.Abstraction;

namespace WeatherApp.Model
{
    public class Temperature : PropertyChangedBase
    {
        private Range minimum;

        public Range Minimum
        {
            get { return minimum; }
            set { minimum = value; OnPropertyChanged()}
        }

        private Range maximum;

        public Range Maximum
        {
            get { return maximum; }
            set { maximum = value; OnPropertyChanged(); }
        }

    }
}
