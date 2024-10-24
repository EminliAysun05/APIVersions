using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Models
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/plants")]
    [ApiController]
    public class PlantsV1Controller : ControllerBase
    {
        
        public List<Plant> plants = new List<Plant>
        {
            new Plant { Id = 1, Name = "Rose", Type = "Flower" },
            new Plant { Id = 2, Name = "Fake Thorn", Type = "Shrub" }
        };

        [HttpGet("v1")]
        public IActionResult GetAll()
        {
            return Ok(plants); 
        }
    }
}
