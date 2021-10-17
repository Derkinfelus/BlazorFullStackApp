using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    interface ISuperHeroService
    {
        event Action OnChange;
        List<SuperHero> Heroes { get; set; }
        List<Comic> Comics { get; set; }
        Task GetHeroes();
        Task GetComics();
        Task<SuperHero> GetSingleHero(int id);
        Task PostSuperHero(SuperHero hero);
        Task PutSuperHero(SuperHero hero, int id);
        Task DeleteHero(int id);
        void Shit();
    }
}
