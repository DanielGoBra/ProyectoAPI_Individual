using ProyectoAPI_Individual.DAL.Entities;

namespace ProyectoAPI_Individual.Domain.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountriesAsync();
        Task<Country> CreateCountryAsync(Country country);
        Task<Country> GetCountryByIdAsync(Guid id);
        Task<Country> GetCountryByNameAsync(string name);
        Task<Country> EditCountryAsync(Country country);
        Task<Country> DeleteCountryAsync(Guid id);
    }
}
