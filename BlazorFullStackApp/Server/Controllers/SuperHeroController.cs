using BlazorFullStackApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        static List<Comic> Comics = new List<Comic>
        {
            new Comic { Data = "Marvel" },
            new Comic { Data = "DC" }
        };

        static List<SuperHero> Heroes = new List<SuperHero>
        {
            new SuperHero { Id = 0, FirstName = "Peter", LastName = "Parker", HeroName = "Spiderman", Comic = Comics[0] },
            new SuperHero { Id = 1, FirstName = "Bruce", LastName = "Wayne", HeroName = "Batman", Comic = Comics[1] },
        };

        [HttpGet]
        public async Task<IActionResult> GetHeroes()
        {
            return Ok(Heroes);
        }

        [HttpGet("comics")]
        public async Task<IActionResult> GetComics()
        {
            return Ok(Comics);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleHero(int id)
        {
            return Ok(Heroes.FirstOrDefault(h => h.Id == id));
        }
    }
}
