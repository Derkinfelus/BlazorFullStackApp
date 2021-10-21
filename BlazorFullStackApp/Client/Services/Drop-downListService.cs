using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    public class Drop_downListService : IDrop_downListService
    {
        public Dictionary<string, OpenableDrop_downList> ListOfElements { get; set; } = new Dictionary<string, OpenableDrop_downList>();
        private readonly HttpClient _HttpClient;

        public event Action OnChange;

        public Drop_downListService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task PostElement(ElementTransporter transporter)
        {
            await _HttpClient.PostAsJsonAsync($"api/Drop_downList", transporter);
            if (ListOfElements.ContainsKey(transporter.Type))
                ListOfElements[transporter.Type].ListElements.Add(new ListElement { Name = transporter.Element.Name, Data = transporter.Element.Data } );
            else
                ListOfElements.Add(transporter.Type, new OpenableDrop_downList
                { Opened = false, ListElements = new List<ListElement> { new ListElement { Name = transporter.Element.Name, Data = transporter.Element.Data } } });
            transporter.Type = "";
            transporter.Element.Name = "";
            transporter.Element.Data = 0;
            OnChange.Invoke();
        }

        public async Task GetList()
        {
            if (ListOfElements.Count == 0)
                foreach (var i in await _HttpClient.GetFromJsonAsync<Dictionary<string, List<ListElement>>>($"api/Drop_downList"))
                {
                    ListOfElements.Add(i.Key, new OpenableDrop_downList { Opened = false, ListElements = new List<ListElement>(i.Value) });
                }
        }
    }
}
