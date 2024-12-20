using System.ComponentModel.DataAnnotations;

namespace Aon_Test.models.DTOs
{
    public class ProdectInputDTO
    {
      
        [Required]
        [MinLength(4, ErrorMessage = "prodect name must be above 4")]
        public string Name { get; set; }
        [Required]
        public decimal price { get; set; }
    }
}
