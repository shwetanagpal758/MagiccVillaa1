using MagicVilla.Web1.Models.Dto;
using MagicVilla_Web1.Models.Dto;

namespace MagicVilla.Web1.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
        Task<T> RegisterAsync<T>(RegisterationRequestDTO objToCreate);
    }
}
