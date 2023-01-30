using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private static List<SuperHero> heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Petter",
                    LastName = "Parker",
                    Place = "New York City"
                },
                 new SuperHero
                {
                    Id = 2,
                    Name = "Batman",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place = "Gotam"
                }

            };
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {


            return Ok(heroes);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<SuperHero>> Get(int id)
        {

            var hero = heroes.Find(x => x.Id == id);
            if (hero == null)
                return BadRequest("Hero not found");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> Addhero(SuperHero hero)
        {
            heroes.Add(hero);
            return Ok(heroes);
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero request)
        {
            var hero = heroes.Find(x => x.Id!= request.Id);
            if (hero == null)
                return BadRequest("Hero not found");
            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            return Ok(hero);
        }                    
    }
}
        