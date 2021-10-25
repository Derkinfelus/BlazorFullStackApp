using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    public class TwodimensionalListService : ITwodimensionalListService
    {
        public Dictionary<string, List<ListElement>> ListOfElements { get; set; } = new Dictionary<string, List<ListElement>>();
        private readonly HttpClient _HttpClient;

        public event Action OnChange;

        public TwodimensionalListService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task PostElement(ElementTransporter transporter)
        {
            var result = await _HttpClient.PostAsJsonAsync($"api/TwoDimantionalList", transporter);
            ListOfElements = await result.Content.ReadFromJsonAsync<Dictionary<string, List<ListElement>>>();
            transporter.Type = "";
            transporter.Element.Name = "";
            transporter.Element.Data = 0;
            OnChange.Invoke();
        }

        public async Task GetList()
        {
            ListOfElements = await _HttpClient.GetFromJsonAsync<Dictionary<string, List<ListElement>>>($"api/TwoDimantionalList");
        }
    }
}
