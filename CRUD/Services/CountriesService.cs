using ServiceContracts;
using ServiceContracts.DTO;
using Entities;

namespace Services;

public class CountriesService : ICountriesService
{
private readonly List<Country> _countries;

    public CountriesService()
    {
        _countries = new List<Country>();
    }

    public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
    {
        //Check if countryAddRequest is not null
        //Validate all properties of countryAddRequest
        //Convert countryAddRequest from CountryAddRequest to Country type
        //Generate a new CountryID
        //Then add it into List<Country>
        //Return Country Response Object with generated CountryID
 
        //Convert object from CountryAddRequest to CountryResponse
        Country country = countryAddRequest.ToCountry();

        //generate countryID
        country.CountryID = Guid.NewGuid();

        //Add country object to the list
        _countries.Add(country);
        return country.ToCountryResponse();

    }

}
