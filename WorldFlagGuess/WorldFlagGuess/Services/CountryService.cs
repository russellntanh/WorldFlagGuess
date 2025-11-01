using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WorldFlagGuess.Models;

namespace WorldFlagGuess.Services
{
    public class CountryService
    {
        private readonly string _filePath;
        public CountryService()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "countries.json");
        }

        public List<Country> GetCountries()
        {
            // check file exists
            if (!File.Exists(_filePath))
                return new List<Country>();


            // read all from file
            var jsonData = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Country>>(jsonData) ?? new List<Country>();
        }
    }
}
