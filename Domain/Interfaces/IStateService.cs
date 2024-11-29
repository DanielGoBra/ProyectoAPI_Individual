using ProyectoAPI_Individual.DAL.Entities;

namespace ProyectoAPI_Individual.Domain.Interfaces
{
    public interface IStateService
    {
        Task<IEnumerable<State>> GetStatesByCountryIdAsync(Guid countryId);
        Task<State> CreateStateAsync(State state, Guid countryId);
        Task<State> GetStateByIdAsync(Guid id);
        Task<State> EditStateAsync(State state, Guid id);
        Task<State> DeleteStateAsync(Guid id);
    }
}
