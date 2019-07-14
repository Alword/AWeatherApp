using WeatherApp.Abstraction;

namespace WeatherApp.Model
{
    public class Area : PropertyChangedBase
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        private string localizedName;

        public string LocalizedName
        {
            get { return localizedName; }
            set { localizedName = value; OnPropertyChanged(); }
        }
    }
}
