using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient _HttpClient;

        public event Action OnChange;

        public List<SuperHero> Heroes { get; set; } = new List<SuperHero>();
        public List<Comic> Comics { get; set; } = new List<Comic>();

        public SuperHeroService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task GetHeroes()
        {
            Heroes = await _HttpClient.GetFromJsonAsync<List<SuperHero>>($"api/superhero");
        }
        public async Task GetComics()
        {
            Comics = await _HttpClient.GetFromJsonAsync<List<Comic>>($"api/superhero/comics");
        }
        public async Task<SuperHero> GetSingleHero(int id)
        {
            return await _HttpClient.GetFromJsonAsync<SuperHero>($"api/superhero/{id}");
        }

        public async Task PostSuperHero(SuperHero hero)
        {
            var result = await _HttpClient.PostAsJsonAsync($"api/superhero", hero);
            Heroes = await result.Content.ReadFromJsonAsync<List<SuperHero>>();
            OnChange.Invoke();
        }

        public async Task PutSuperHero(SuperHero hero, int id)
        {
            var result = await _HttpClient.PutAsJsonAsync($"api/superhero/{id}", hero);
            Heroes = await result.Content.ReadFromJsonAsync<List<SuperHero>>();
            OnChange.Invoke();
        }

        public async Task DeleteHero(int id)
        {
            var result = await _HttpClient.DeleteAsync($"api/superhero/{id}");
            Heroes = await result.Content.ReadFromJsonAsync<List<SuperHero>>();
            OnChange.Invoke();
        }

        public void Shit()
        {
            OnChange.Invoke();
        }
    }
}
