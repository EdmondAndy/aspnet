using System;
using Entities;

namespace ServiceContracts.DTO
{
    /// <summary>
    /// DTO class for Country entity to be used as return type of service methods
    /// </summary>
    public class CountryResponse
    {
        public Guid CountryID { get; set; }
        public string? CountryName { get; set; }

        // public static CountryResponse FromCountry(Country country)
        // {
        //     return new CountryResponse()
        //     {
        //         CountryID = country.CountryID,
        //         CountryName = country.CountryName
        //     };
        // }
    }

    public static class CountryExtensions
        {
            public static CountryResponse ToCountryResponse(this Country country)
            {
                return new CountryResponse()
                {
                    CountryID = country.CountryID,
                    CountryName = country.CountryName
                };
            }
        }
    
}