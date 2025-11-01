using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorldFlagGuess.Models;
using WorldFlagGuess.Services;

namespace WorldFlagGuess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Country> _countries;
        private CountryService _countryService;
        public MainWindow()
        {
            InitializeComponent();
            _countryService = new CountryService();
            _countries = _countryService.GetCountries();
            CountryListBox.ItemsSource = _countries;
        }

        private void CountryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CountryListBox.SelectedItem is Country country)
            {
                TxtName.Text = $"Nation: {country.Name}";
                TxtCapital.Text = $"Capital: {country.Capital}";
                TxtContinent.Text = $"Region: {country.Continent}";
                TxtPopulation.Text = $"Population: {country.Population}";
                TxtArea.Text = $"Area: {country.Area}";

                DetailPanel.Visibility = Visibility.Visible;

            }
        }
    }
}