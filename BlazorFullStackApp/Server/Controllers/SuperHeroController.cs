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
            new Comic { Id = 0, Data = "Marvel" },
            new Comic { Id = 1, Data = "DC" }
        };

        static List<SuperHero> Heroes = new List<SuperHero>
        {
            new SuperHero { Id = 0, FirstName = "Peter", LastName = "Parker", HeroName = "Spiderman", ComicId = 0 },
            new SuperHero { Id = 1, FirstName = "Bruce", LastName = "Wayne", HeroName = "Batman", ComicId = 1 },
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

        [HttpPost]
        public async Task<IActionResult> CreateHero(SuperHero hero)
        {
            Heroes.Add(hero);
            return Ok(Heroes);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHero(SuperHero hero, int id)
        {
            var tmp = Heroes.FirstOrDefault(x => x.Id == id);
            tmp.FirstName = hero.FirstName;
            tmp.LastName = hero.LastName;
            tmp.HeroName = hero.HeroName;
            tmp.ComicId = hero.ComicId;

            return Ok(Heroes);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(int id)
        {
            Heroes.Remove(Heroes.FirstOrDefault(x => x.Id == id));
            return Ok(Heroes);
        }
    }
}
