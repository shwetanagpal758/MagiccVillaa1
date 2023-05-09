using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla.Web1.Models.Dto
{
    public class VillaNumberUpdateDTO
    {
        internal readonly VillaNumberUpdateDTO VillaNumber;

        [Required]
        public int VillaNo { get; set; }
        
        [Required]
        public int VillaID { get; set; }

        public string SpecialDetails { get; set; }
        public IEnumerable<SelectListItem> VillaList { get; internal set; }
    }
}
