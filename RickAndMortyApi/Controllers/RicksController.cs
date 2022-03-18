using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickAndMortyApi.Models;

namespace RickAndMortyApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RicksController : ControllerBase
    {
        List<Rick> ricks = new List<Rick>()
        {
            new Rick() { Id = 1, Name = "Rick Campesino", Description = "Le gusta sembrar mega semillas", Universo = "C-154"},
            new Rick() { Id = 2, Name = "Rick Presidente", Description = "Conserva el capitalismo de las ciudadela de los Rivks", Universo = "C-183"}
        };

        public IActionResult Get()
        {
            return new JsonResult(ricks);
        }
        
        [Route("getrick")]
        public IActionResult Get(int id)
        {
            return new JsonResult(ricks.Find(x => x.Id == id));
        }

        [Route("addrick")]
        public void Post([FromBody]Rick rick)
        {
            ricks.Add(rick);
        }
        
    }
}
