using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/plants")]
    [ApiController]
    public class PlantsV2Controller : ControllerBase
    {
        public static readonly List<Plant> plants = new List<Plant>
        { new Plant { Id = 1, Name = "Rose", Type = "Flower"},
          new Plant { Id = 2, Name = "Fake Thorn", Type = "Shrub" },
          new Plant { Id = 3, Name = "Cactus", Type = "Succulent" }
        };

        [HttpGet("v2")]
        public ActionResult<IEnumerable<Plant>> GetAll()
        {
            return Ok(plants);
        }
    }
}
