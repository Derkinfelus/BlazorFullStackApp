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
        public OpenableMultiDimensionalList HightestDimensionElement { get; set; } = new OpenableMultiDimensionalList();
        public int MaxId { get; set; } = new int();
        private readonly HttpClient _HttpClient;

        public event Action OnChange;

        public MultiDimensionalListService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task PostElement(OpenableMultiDimensionalList element)
        {
            var tmp = await _HttpClient.PostAsJsonAsync($"api/MultiDimensionalList", await element.TransformElement());
            element.Id = await tmp.Content.ReadFromJsonAsync<int>();
            (await HightestDimensionElement.FindElement(element.ParrentId)).LowerDimensionList.Add(element);

            OnChange.Invoke();
        }

        public async Task GetHightestDimensionElement()
        {
            HightestDimensionElement = await (await _HttpClient.GetFromJsonAsync<MultiDimensionalList>($"api/MultiDimensionalList")).TransformElement();


            OnChange.Invoke();
        }
    }
}
