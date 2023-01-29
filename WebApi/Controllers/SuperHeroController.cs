using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var hereos = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Petter",
                    LastName = "Parker",
                    Place = "New York City"
                }
            };

            return Ok(hereos);
        }
    }
}
        