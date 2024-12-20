using Aon_Test.models.DTOs;
using Aon_Test.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Aon_Test.Services;

namespace Aon_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdectController(prodectSerives prodectSerives) : ControllerBase
    {
       public int i = 1;
       
        [HttpPost]
        public async Task<IActionResult> CreateNewProdect(ProdectInputDTO prodectInputDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid inputs");
              
              var prodect = new Prodects
            {
                Id = i,
                Name = prodectInputDTO.Name,
                price = prodectInputDTO.price
            };
            i++;
            prodectSerives.AddNewProdect(prodect);
            

            return Ok("You add new Prodect.");
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProdectById( int productId)
        {
            
            Prodects storedProdect = prodectSerives.GetProdectById(productId);
            if (storedProdect == null)
                return BadRequest("Prodect not found.");

            return Ok(storedProdect);
        }
    }
}
