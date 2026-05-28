using Entities;

namespace ContactsManager.Core.Domain.RepositoryContracts
{
    public interface ICountriesRepository
    {
        Task<Country> AddCountry(Country country);
        Task<Country?> GetCountryByCountryId(Guid countryId);
        Task<Country?> GetCountryByName(string countryName);
        Task<List<Country>> GetAllCountries();
    }
}
