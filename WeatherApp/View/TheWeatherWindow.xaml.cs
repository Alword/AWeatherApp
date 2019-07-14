using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WeatherApp.ViewModel;

namespace WeatherApp.View
{
    /// <summary>
    /// Логика взаимодействия для TheWeatherWindow.xaml
    /// </summary>
    public partial class TheWeatherWindow : Window
    {
        public TheWeatherWindow()
        {
            InitializeComponent();

            GetWeather();
        }

        private async void GetWeather()
        {
            //var weather = await WeatherApi.GetCity();
        }
    }
}
