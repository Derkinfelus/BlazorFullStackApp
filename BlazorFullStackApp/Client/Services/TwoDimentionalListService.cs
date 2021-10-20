﻿using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    public class TwoDimentionalListService : ITwoDimentionalListService
    {
        public Dictionary<string, List<ListElement>> ListOfElements { get; set; } = new Dictionary<string, List<ListElement>>();
        private readonly HttpClient _HttpClient;

        public event Action OnChange;

        public TwoDimentionalListService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task PostElement(ElementTransporter transporter)
        {
            var result = await _HttpClient.PostAsJsonAsync($"api/TwoDimantionalList", transporter);
            ListOfElements = await result.Content.ReadFromJsonAsync<Dictionary<string, List<ListElement>>>();
            OnChange.Invoke();
        }

        public async Task GetList()
        {
            ListOfElements = await _HttpClient.GetFromJsonAsync<Dictionary<string, List<ListElement>>>($"api/TwoDimantionalList");
        }
    }
}
