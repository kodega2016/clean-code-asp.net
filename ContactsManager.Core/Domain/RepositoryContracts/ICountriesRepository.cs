using ContactsManager.Core.Domain.Entities;

namespace ContactsManager.Core.Domain.RepositoryContracts
{
    ///<summary>
    /// Represents data class access logic for managing the Country entity
    ///</summary>
    public interface ICountriesRepository
    {
        ///<summary>
        /// Adds a new country object to the data store
        ///</summary>
        ///<param name="country">Country to add to the data store</param>
        ///<return>The country that is added will be returned as Country entity</return>
        Task<Country> AddCountry(Country country);

        ///<summary>
        /// Returns a country object based on the given country id;otherwise returns null
        ///</summary>
        ///<param name="countryId">Country to search</param>
        ///<return>Matching country or null</return>
        Task<Country?> GetCountryByCountryId(Guid countryId);

        ///<summary>
        /// Returns a country object based on the given country name
        ///</summary>
        ///<param name="countryName">Country name to search</param>
        ///<return>Return the country object or null</return>
        Task<Country?> GetCountryByName(string countryName);

        ///<summary>
        ///Get all the countries object</summary>
        ///</summary>
        ///<return>Return the list of country</return>
        Task<List<Country>> GetAllCountries();
    }
}
