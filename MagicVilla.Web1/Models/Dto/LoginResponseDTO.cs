

using MagicVilla.Web1.Models.Dto;

namespace MagicVilla_Web1.Models.Dto
{
    public class LoginResponseDTO
    {
        public UserDTO user { get; set; }
        public string Token { get; set; }

    }
}
