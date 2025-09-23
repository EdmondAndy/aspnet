using ServiceContracts.DTO;

namespace ServiceContracts;

/// <summary>
/// Represents business logic for manipulating
/// </summary>
public interface ICountriesService
{
    /// <summary>
    /// Adds a country object to the list of countries
    /// </summary>
    /// <param name="countryAddRequest"></param>
    /// <returns>Return the country object after adding it (including newly generated ID)</returns>
    CountryResponse AddCountry(CountryAddRequest? countryAddRequest);
}
