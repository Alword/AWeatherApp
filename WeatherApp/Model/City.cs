using System.ComponentModel;
using WeatherApp.Abstraction;
namespace WeatherApp.Model
{
    public class City : PropertyChangedBase
    {
        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; OnPropertyChanged(); }
        }
        private string localizedName;

        public string LocalizedName
        {
            get { return localizedName; }
            set { localizedName = value; OnPropertyChanged(); }
        }

        private Area country;

        public Area Country
        {
            get { return country; }
            set { country = value; OnPropertyChanged(); }
        }

        private Area administrativeArea;

        public Area AdministrativeArea
        {
            get { return administrativeArea; }
            set { administrativeArea = value; OnPropertyChanged(); }
        }
    }
}
