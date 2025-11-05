using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldFlagGuess.Models;
using WorldFlagGuess.Services;

namespace WorldFlagGuess.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly CountryService _countryService;

        public ObservableCollection<Country> Countries { get; set; }

        private Country _selectedCountry;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Country SelectedCountry
        {
            get => _selectedCountry;
            set
            {
                _selectedCountry = value;
                OnPropertyChanged(nameof(SelectedCountry));
            }
        }

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public MainViewModel()
        {
            _countryService = new CountryService();
            var countryList = _countryService.GetCountries();
            Countries = new ObservableCollection<Country>(countryList);
        }
    }
}
