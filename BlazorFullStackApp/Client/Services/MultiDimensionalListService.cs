using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    public class MultiDimensionalListService : IMultiDimensionalListService
    {
        public OpenableMultiDimensionalList HightestDimensionElement { get; set; }
        public int MaxId { get; set; } = new int();
        private readonly HttpClient _HttpClient;

        public event Action OnChange;

        public MultiDimensionalListService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task PostElement(OpenableMultiDimensionalList element)
        {
            var result = await _HttpClient.PostAsJsonAsync($"api/MultiDimensionalList", await element.TransformElement());
            element.Id = await result.Content.ReadFromJsonAsync<int>();
            OpenableMultiDimensionalList toAdd = new OpenableMultiDimensionalList
            {
                Id = element.Id,
                ParrentId = element.ParrentId,
                IsOpen = element.IsOpen,
                Data = element.Data,
                Name = element.Name,
                LowerDimensionList = element.LowerDimensionList
            };
            element.Id = -1;
            element.Name = "";
            element.Data = 0;

            var parrent = await HightestDimensionElement.FindElement(element.ParrentId);
            parrent.IsOpen = true;
            parrent.LowerDimensionList.Add(toAdd);

            OnChange.Invoke();
        }

        public async Task PutElement(OpenableMultiDimensionalList element)
        {
            await _HttpClient.PutAsJsonAsync($"api/MultiDimensionalList", await element.TransformElement());

            OnChange.Invoke();
        }

        public async Task GetHightestDimensionElement()
        {
            HightestDimensionElement = await (await _HttpClient.GetFromJsonAsync<MultiDimensionalList>($"api/MultiDimensionalList")).TransformElement();
            HightestDimensionElement.IsOpen = true;

            OnChange.Invoke();
        }
    }
}
