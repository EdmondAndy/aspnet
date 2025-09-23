using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using ServiceContracts.DTO;
using ServiceContracts;
using Services;
using Xunit;

namespace MyUnitTest
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService _countriesService;

        public CountriesServiceTest()
        {
            _countriesService = new CountriesService();
        }

        //When CountryAddRequest is null, it should throw ArgumentNullException
        [Fact]
        public void AddCountry_NullCountry()
        {
            //Arrange
            CountryAddRequest? countryAddRequest = null;

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => { _countriesService.AddCountry(countryAddRequest); });
        }

        //When the CountryName is null, it should throw ArgumentException
        [Fact]
        public void AddCountry_CountryNameIsNull()
        {
            //Arrange
            CountryAddRequest? countryAddRequest = new CountryAddRequest()
            {
                CountryName = null
            };

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => { _countriesService.AddCountry(countryAddRequest); });
        }

        //When the CountryName is duplicate, it should throw AugumentException
        [Fact]
        public void AddCountry_DuplicateCountryName()
        {
            //Arrange
            CountryAddRequest? countryAddRequest1 = new CountryAddRequest()
            {
                CountryName = "USA"
            };

            CountryAddRequest? countryAddRequest2 = new CountryAddRequest()
            {
                CountryName = "USA"
            };

            //Act & Assert
            Assert.Throws<ArgumentException>(() => { _countriesService.AddCountry(countryAddRequest1); _countriesService.AddCountry(countryAddRequest2); });
        }
        //When you supply proper country name, it should insert (add) the country to the existing list of countries
        [Fact]
        public void AddCountry_ValidCountry()
        {
            //Arrange
            CountryAddRequest? countryAddRequest = new CountryAddRequest()
            {
                CountryName = "Canada"
            };

            //Act & Assert
            CountryResponse response = _countriesService.AddCountry(countryAddRequest);
            Assert.True(response.CountryID != Guid.Empty);
        }

    }
    
}