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
        ///<returns>The country that is added will be returnsed as Country entity</returns>
        Task<Country> AddCountry(Country country);

        ///<summary>
        /// returnss a country object based on the given country id;otherwise returnss null
        ///</summary>
        ///<param name="countryId">Country to search</param>
        ///<returns>Matching country or null</returns>
        Task<Country?> GetCountryByCountryId(Guid countryId);

        ///<summary>
        /// returnss a country object based on the given country name
        ///</summary>
        ///<param name="countryName">Country name to search</param>
        ///<returns>returns the country object or null</returns>
        Task<Country?> GetCountryByName(string countryName);

        ///<summary>
        ///Get all the countries object</summary>
        ///</summary>
        ///<returns>returns the list of country</returns>
        Task<List<Country>> GetAllCountries();
    }
}
