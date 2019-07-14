using WeatherApp.Abstraction;
namespace WeatherApp.Model
{
    public class TimeOfDay : PropertyChangedBase
    {
        private int icon;

        public int Icon
        {
            get { return icon; }
            set { icon = value; OnPropertyChanged(); }
        }

        private string iconPhrase;

        public string IconPhrase
        {
            get { return iconPhrase; }
            set { iconPhrase = value; OnPropertyChanged(); }
        }

        private bool hasPrecipitation;

        public bool HasPrecipitation
        {
            get { return hasPrecipitation; }
            set { hasPrecipitation = value; OnPropertyChanged(); }
        }
    }
}
