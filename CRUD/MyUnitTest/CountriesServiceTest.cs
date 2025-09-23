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

        #region AddCountry
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
    //When you supply proper country name, it should insert (add) the country to the existing list of countries
        [Fact]
        public void AddCountry_ProperCountryDetails()
        {
            //Arrange
            CountryAddRequest? request = new CountryAddRequest() { CountryName = "Japan" };

            //Act
            CountryResponse response = _countriesService.AddCountry(request);
            List<CountryResponse> countries_from_GetAllCountries = _countriesService.GetAllCountries();

            //Assert
            Assert.True(response.CountryID != Guid.Empty);
            Assert.Contains(response, countries_from_GetAllCountries);
        }
        #endregion
        #region GetAllCountries

        //The list of countries should be empty by default (before adding any countries)
        [Fact]
        public void GetAllCountries_EmptyList()
        {
            //Arrange
            //Act
            List<CountryResponse> countries = _countriesService.GetAllCountries();

            //Assert
            Assert.Empty(countries);
        }

        [Fact]
        public void GetAllCountries_AddFewCountries()
        {
            //Arrange
            List<CountryAddRequest> country_request_list = new List<CountryAddRequest>()
            {
                new CountryAddRequest(){ CountryName="USA"},
                new CountryAddRequest(){ CountryName="Canada"},
                new CountryAddRequest(){ CountryName="UK"}
            };
            //Act
            List<CountryResponse> country_list_from_add_country = new List<CountryResponse>();

            foreach (CountryAddRequest countryRequest in country_request_list)
            {
                country_list_from_add_country.Add(_countriesService.AddCountry(countryRequest));
            }

            List<CountryResponse> actualCountryResponseList = _countriesService.GetAllCountries();

            //read each element from countries_list_from_add_country
            foreach (CountryResponse expected_country in country_list_from_add_country)
            {
                Assert.Contains(expected_country, actualCountryResponseList);
            }
            
        }        

        #endregion
    }
    
}